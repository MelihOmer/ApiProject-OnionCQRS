using FluentValidation;
using MediatR;

namespace ApiProject.Application.Beheviors
{
    public class FluentValidationBehevior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> validator;

        public FluentValidationBehevior(IEnumerable<IValidator<TRequest>> validator)
        {
            this.validator = validator;
        }
        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);

            var failtures = validator
                .Select(x => x.Validate(context))
                .SelectMany(result => result.Errors)
                .GroupBy(x=> x.ErrorMessage)
                .Select(s => s.First())
                .Where(w => w !=null)
                .ToList();

            if (failtures.Any())
                throw new ValidationException(failtures);

            return next();
        }
    }
}
