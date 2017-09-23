using Practica.Models;
using Practica.Repositories.Credit;
using Practica.Repositories.Dapper.Credit;
using System;
using System.Linq;
using Xunit;

namespace Practica.Repositories.DapperTests
{
    public class CorporationRepositoryTest
    {
        private ICorporationRepository repo;

        public CorporationRepositoryTest()
        {
            repo = new CorpotarionRepository("Server=.;Database=credit; Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        [Fact (DisplayName = "[CorporationRepository]Get All")]
        public void Corporation_Reposiroty_GetAll()
        {
            var result = repo.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[CustomerRepository]Get By Id")]
        public void Customer_Reposiroty_Get_By_Id()
        {
            var customer = repo.GetById(10);
            Assert.True(customer != null);
        }


        [Fact(DisplayName = "[CorporationRepository]Insert")]
        public void Corporation_Repository_Insert()
        {
            var corporation = GetNewCorporation();
            var result = repo.Insert(corporation);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "[CustomerRepository]Delete")]
        public void Customer_Repository_Delete()
        {
            var corporation = GetNewCorporation();
            var result = repo.Insert(corporation);
            Assert.True(repo.Delete(corporation));
        }

        [Fact(DisplayName = "[CustomerRepository]Update")]
        public void Customer_Repository_Update()
        {
            var corporation = repo.GetById(10);
            Assert.True(corporation != null);
            //corporation.expr_dt = $"Today {DateTime.Now.ToShortDateString()}";
            Assert.True(repo.Update(corporation));
        }

        private Corporation GetNewCorporation()
        {
            return new Corporation
            {
                corp_no=1,
                corp_name="Wong",
                street="",
                city="",
                state_prov="",
                country="",
                mail_code="",
                phone_no="",
                expr_dt = DateTime.Now,
                corp_code=""

            };
        }
    }
}
