using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;
using ValidationException = FluentValidation.ValidationException;

namespace ApiProject.Application.Exceptions
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpContext, RequestDelegate next)
        {
			try
			{
				await next(httpContext);
			}
			catch (Exception ex)
			{

				await HandleExceptionAsync(httpContext, ex);
			}
        }
		private static  Task HandleExceptionAsync(HttpContext httpContext, Exception ex) 
		{
			int statusCode = GetStatusCode(ex);
			httpContext.Response.ContentType = "application/json";
			httpContext.Response.StatusCode = statusCode;

			if (ex.GetType() == typeof(ValidationException))
				return httpContext.Response.WriteAsync(new ExceptionModel
				{
					Errors = ((ValidationException)ex).Errors.Select(x => x.ErrorMessage),
					StatusCode = statusCode
				}.ToString());

			List<string> errors = new()
			{
				$"Hata Mesajı : {ex.Message}"
			};


			var exception = new ExceptionModel
			{
                Errors = errors,
                StatusCode = statusCode
            }.ToString();
			return httpContext.Response.WriteAsync(exception);
			//return httpContext.Response.WriteAsync(new ExceptionModel
			//{
			//	Errors = errors,
			//	StatusCode = statusCode
			//}.ToString());
		}
		private static int GetStatusCode(Exception exception)
		{
			return exception switch
			{
				BadRequestException => StatusCodes.Status400BadRequest,
				NotFoundException => StatusCodes.Status404NotFound,
				ValidationException => StatusCodes.Status422UnprocessableEntity,
				_ => StatusCodes.Status500InternalServerError
			};
		}
    }
}
