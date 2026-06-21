using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Commands.UpdateMaterialRequest
{
    public class UpdateMaterialRequestCommand : IRequest
    {
        public Guid Id { get; set; }

        public string MaterialType { get; set; }

        public double TargetQuantity { get; set; }

        public double LocationPreferenceRadiusKm { get; set; }
    }
}
