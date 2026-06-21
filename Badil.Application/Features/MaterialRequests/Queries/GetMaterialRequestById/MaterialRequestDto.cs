using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badil.Application.Features.MaterialRequests.Queries.GetMaterialRequestById
{
    public class MaterialRequestDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string MaterialType { get; set; }

        public double TargetQuantity { get; set; }

        public double LocationPreferenceRadiusKm { get; set; }
    }
}
