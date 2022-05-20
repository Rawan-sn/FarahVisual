using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarahProjest.Models;

namespace FarahProjest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyBeneficiaryController : ControllerBase
    {
        private readonly FarahContext _context;

        public FamilyBeneficiaryController(FarahContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetFamilyBeneficiary(Guid FamilyMemberId)
        {
            var data = _context.TbFamilyBeneficiaries.Select(
             x => new
             {
                 FamilyId = x.FamilyBeneficiaryId ,
                 NiceName = x.NiceName,
                 BirthDate = x.Phone,
                 Address = x.Address ,
                 DetectionDate = x.DetectionDate,
                 DetectionReport = x.DetectionReport,
                 OrderSenderName = x.OrderSenderName ,
                 OrderSenderAdj = x.OrderSenderAdj,
                 FamilyIncoming = x.FamilyIncoming,
                 MonthlyIncoming = x.MonthlyIncoming ,
                 OtherIncoming = x.OtherIncoming ,
                 FamilyStauts = x.FamilyStatusId,
             }
             );
            return Ok(data);
        }

        [HttpGet("DemandOrder/{FamilyId:Guid}")]
        public IActionResult GetDemandOrder(Guid FamilyId)
        {
            var data = _context.TbDemandOrders.Where(m => m.FamilyBeneficiaryId == FamilyId).Select(
             x => new
             {
                 DemandOrderId = x.DemandOrderId,
                 DemandOrderDate = x.DemandOrderDate,
                 BirthDate = x.DescriptionDemand,
                 AcceptOrderDate = x.AcceptOrderDate,
                 RejectOrderDate = x.RejectOrderDate,
                 ReliabilityPhoto = x.ReliabilityPhoto,
                 NumberOrder = x.NumberOrder,
                 StatusOrder = x.StatusOrder
             }
             );
            return Ok(data);
        }
    }
}
