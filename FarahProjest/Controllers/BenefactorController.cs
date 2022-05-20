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
    public class BenefactorController : ControllerBase
    {
        private readonly FarahContext _context;

        public BenefactorController(FarahContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBenefactor()
        {
            var data = _context.TbBenefactors.Select(
             x => new
             {
                 BenefactorId = x.BenefactorId,
                 BenefactorName = x.BenefactorName,
                 Phone = x.Phone,
                 Address = x.Address,
                 Gender = x.Gender,
                 Occupation = x.Occupation ,
                 Donations = x.TbDonations.Select(c => new
                 {
                     DonationId = c.DonationId,
                     DonationDescription = c.DonationDescription,
                     DonationDate = c.DonationDate,
                     DonationNumber = c.DonationNumber,
                     TypeDonation = c.TypeDonation,
                     DonationValue = c.DonationValue,
                     RecievedDate = c.RecievedDate ,
                     StatusDonation = c.StatusDonation,
                     MaterialName = c.Material.MaterialName ,
                     AmountMaterial = c.Amount,
                     StatusOfMaterial = c.StatusOfMaterial ,


                 }).ToList(),

             }
             );
            return Ok(data);
        }
        [HttpGet("MyDonation/{BenefactorId:Guid}/{Type}")]

        public IActionResult GetMyDonation(Guid BenefactorId, string Type)
        {
            var data = _context.TbBenefactors.Where(m => m.BenefactorId == BenefactorId).Select( x => new
             {
                 BenefactorId = x.BenefactorId,
                 BenefactorName = x.BenefactorName,
                 Phone = x.Phone,
                 Address = x.Address,
                 Gender = x.Gender,
                 Occupation = x.Occupation,
                 Donations = x.TbDonations.Where(m => m.TypeDonation == Type).Select(c => new
                 {
                     DonationId = c.DonationId,
                     DonationDescription = c.DonationDescription,
                     DonationDate = c.DonationDate,
                     DonationNumber = c.DonationNumber,
                     TypeDonation = c.TypeDonation,
                     DonationValue = c.DonationValue,
                     RecievedDate = c.RecievedDate,
                     StatusDonation = c.StatusDonation,
                     MaterialName = c.Material.MaterialName,
                     AmountMaterial = c.Amount,
                     StatusOfMaterial = c.StatusOfMaterial,


                 }).ToList(),

             }
             );
            return Ok(data);
        }
        /* public IActionResult GetMyDonation(Guid BenefactorId , string Type)
         {
             var data = _context.TbDonations.Where(m => m.Benefactor.BenefactorId == BenefactorId && m.TypeDonation == Type).Select(
              x => new
              {
                      BenefactorId = x.Benefactor.BenefactorId,
                      BenefactorName = x.Benefactor.BenefactorName,
                      Phone = x.Benefactor.Phone,
                      Address = x.Benefactor.Address,
                      Gender = x.Benefactor.Gender,
                      Occupation = x.Benefactor.Occupation,
                      DonationId = x.DonationId,
                      DonationDescription = x.DonationDescription,
                      DonationDate = x.DonationDate,
                      DonationNumber = x.DonationNumber,
                      TypeDonation = x.TypeDonation,
                      DonationValue = x.DonationValue,
                      RecievedDate = x.RecievedDate,
                      StatusDonation = x.StatusDonation,
                      MaterialName = x.Material.MaterialName,
                      AmountMaterial = x.Amount,
                      StatusOfMaterial = x.StatusOfMaterial,



              }
              );
             return Ok(data);
         }
 */

        [HttpGet("Donation/{BenefactorId:Guid}")]
        public IActionResult GetDonation(Guid BenefactorId)
        {

            var data = _context.TbDonations.Where(m => m.BenefactorId == BenefactorId).Select(
             x => new
             {
                 BenefactorId = x.Benefactor.BenefactorId,
                 BenefactorName = x.Benefactor.BenefactorName,
                 Phone = x.Benefactor.Phone,
                 Address = x.Benefactor.Address,
                 Gender = x.Benefactor.Gender,
                 Occupation = x.Benefactor.Occupation,
                 DonationId = x.DonationId,
                 DonationDescription = x.DonationDescription,
                 DonationDate = x.DonationDate,
                 DonationNumber = x.DonationNumber,
                 TypeDonation = x.TypeDonation,
                 DonationValue = x.DonationValue,
                 RecievedDate = x.RecievedDate,
                 StatusDonation = x.StatusDonation,
                 MaterialName = x.Material.MaterialName,
                 AmountMaterial = x.Amount,
                 StatusOfMaterial = x.StatusOfMaterial,




             }
             );

            /*
            var data = _context.TbDonations.Where(m => m.BenefactorId == BenefactorId).Select(
             x => new
             {
                 DonationId = x.DonationId,
                 BenefactorId = x.Benefactor.BenefactorId,
                 BenefactorName = x.Benefactor.BenefactorName,
                 DonationDescription = x.DonationDescription,
                 DonationDate = x.DonationDate,
                 DonationNumber = x.DonationNumber,
                 TypeDonation = x.TypeDonation,
                 DonationValue = x.DonationValue,
                 RecievedDate = x.RecievedDate,
                 StatusDonation = x.StatusDonation,
                 MaterialName = x.Material.MaterialName,
                 AmountMaterial = x.Amount,
                 StatusOfMaterial = x.StatusOfMaterial,

             }
             );*/


            return Ok(data);
        }
    }
}
