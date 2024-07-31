using Microsoft.Extensions.Logging;
using My_App.Application.Core.Abstractions.Authentication;
using My_App.Application.Core.Abstractions.Data;
using My_App.Application.Core.Abstractions.Emails;
using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Core.TypeBase.Result;
using My_App.Domain.Products;

namespace My_App.Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
{
    private readonly IProductRepository _productRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IEmailService _emailService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateProductCommandHandler> _logger;

    public CreateProductCommandHandler(IProductRepository productRepository, IJwtProvider jwtProvider, IEmailService emailService, IUnitOfWork unitOfWork, ILogger<CreateProductCommandHandler> logger)
    {
        _productRepository = productRepository;
        _jwtProvider = jwtProvider;
        _emailService = emailService;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public Task<Result> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
