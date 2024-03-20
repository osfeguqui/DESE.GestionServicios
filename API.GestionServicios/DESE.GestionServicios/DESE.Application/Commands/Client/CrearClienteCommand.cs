using AutoMapper;
using DESE.Application.Dtos;
using DESE.Application.Interfaces;
using DESE.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace DESE.Application.Commands.Client
{
    public class CrearClienteCommand : IRequest<ClienteDto>
    {
        public int? NumeroDocumentoIdentidad { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Empresa { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? OtrosDetalles { get; set; }
    }

    public class CrearClienteCommandHandler : IRequestHandler<CrearClienteCommand, ClienteDto>
    {
        private readonly IMediator _mediator;
        private readonly IApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<CrearClienteCommandHandler> _logger;

        public CrearClienteCommandHandler(IMediator mediator, IApplicationDbContext dbContext, IMapper mapper, ILogger<CrearClienteCommandHandler> logger)
        {
            _mediator = mediator;
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ClienteDto> Handle(CrearClienteCommand request, CancellationToken cancellationToken)
        {
            var cliente = new Cliente
            {
                NumeroDocumentoIdentidad = request.NumeroDocumentoIdentidad,
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Empresa = request.Empresa,
                Direccion = request.Direccion,
                Telefono = request.Telefono,
                CorreoElectronico = request.CorreoElectronico,
                OtrosDetalles = request.OtrosDetalles
            };

            _dbContext.Clientes.Add(cliente);
            await _dbContext.SaveChangesAsync(cancellationToken);

            _logger.LogInformation("Cliente creado: {NumeroDocumentoIdentidad}", cliente.NumeroDocumentoIdentidad);

            return _mapper.Map<ClienteDto>(cliente);
        }

    }
}
