using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UhintsMvc.DataAccess;

namespace UhintsMvc.Models
{
    public class MedicalHistory
    {
        public long ID {get; set;}
        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? EndDt  { get; set; }

        ///
        /// Returns the many records a customer may have.
        ///
        public static List<MedicalHistory> Records(UnifiedhintsEntities repo, long userId)
        {
            return (from a in repo.tbl_Ailments 
             join ca in repo.tbl_Customer_Ailment
             on a.ailment_id equals ca.ailment_id
             where ca.customer_id == userId
             select new MedicalHistory(){
                ID =  ca.cust_ailment_id,
                Name =  a.ailment_name,
                Nickname =  ca.ailment_nickname,
                StartDt =  ca.start_date,
                EndDt =  ca.end_date
             }).ToList();
        }

        public tbl_Customer_Ailment ToCustomerAilment(long ailmentid)
        {
            return new tbl_Customer_Ailment()
            {
                ailment_nickname = this.Nickname,
                start_date = this.StartDt == null || this.StartDt == DateTime.MinValue ? (DateTime?)null : DateTime.Now,
                end_date = this.EndDt == null || this.EndDt == DateTime.MinValue ? (DateTime?)null : DateTime.Now,
                entry_date = DateTime.Now,
                change_date = DateTime.Now,
                ailment_id = ailmentid
            };
        }

        public tbl_Ailments ToAilment()
        {
            return new tbl_Ailments()
            {
                ailment_name = this.Name,
                entry_date = DateTime.Now,
                change_date = DateTime.Now
            };
        }

        public Tuple<tbl_Ailments, tbl_Customer_Ailment> Create(UnifiedhintsEntities repository)
        {
            var ailment = repository.tbl_Ailments.Add(this.ToAilment());

            repository.SaveChanges();

            var customer_ailment = repository.tbl_Customer_Ailment.Add(this.ToCustomerAilment(ailment.ailment_id));

            repository.SaveChanges();

            return new Tuple<tbl_Ailments, tbl_Customer_Ailment>(ailment, customer_ailment);
        }
    }
}