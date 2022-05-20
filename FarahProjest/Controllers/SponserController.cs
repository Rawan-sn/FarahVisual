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
    public class SponserController : ControllerBase
    {
        private readonly FarahContext _context;

        public SponserController(FarahContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetSponser(Guid FamilyMemberId)
        {
            var data = _context.TbSponsers.Select(
             x => new
             {
                 SponserId = x.SponserId,
                 SponserName = x.SponserName,
                 Phone = x.Phone,
                 Age = x.Age,
                 Gender = x.Gender,
                 Mobile = x.Mobile,
                 SponserAddress = x.SponserAddress ,
                
             }
             );
            return Ok(data);
        }

        public IActionResult GetSponserOrder(Guid SponserId)
        {
            var data = _context.TbSponserOrders.Where(m => m.SponserId == SponserId).Select(
             x => new
             {
                 SponserOrderId = x.SponserOrderId,
                 SponserId = x.SponserId,
                 StartingDate = x.StartingDate,
                 EndingDate = x.EndingDate,
                 SponsorRejectDate = x.SponsorRejectDate,
                 SponsorAcceptDate = x.SponsorAcceptDate,
                 NumberOrder = x.NumberOrder,
                 SponserShipPeriod = x.SponserShipPeriod,
                 StatusOrder = x.StatusOrder ,
                 FamilyBeneficiary = x.FamilyBeneficiary.FamilyBeneficiaryId,
                 FamilyName = x.FamilyBeneficiary.NiceName ,

             }
             );
            return Ok(data);
        }


        public IActionResult GetSponserOffer(Guid SponserOrderId)
        {
            var data = _context.TbOffers.Where(m => m.SponserOrderId == SponserOrderId).Select(
             x => new
             {
                 SponserOrderId = x.SponserOrderId,
                 SponserId = x.SponserOrder.SponserId,
                 StartingDate = x.OfferDate,
                 EndingDate = x.OfferRejectDate,
                 SponsorRejectDate = x.OfferAcceptDate,
                 SponsorAcceptDate = x.TypeOffer,
                 NumberOrder = x.OfferNumber,

             }
             );
            return Ok(data);
        }
    }
}
