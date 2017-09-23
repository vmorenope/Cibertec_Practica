using Practica.Models;
using Practica.Repositories.Credit;
using Practica.Repositories.Dapper.Credit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Practica.Repositories.DapperTests
{
    public class MemberRepositoryTest
    {
        private IMemberRepository repo;

        public MemberRepositoryTest()
        {
            repo = new MemberRepository("Server=.;Database=credit; Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        [Fact(DisplayName = "[MemberRepository]Get All")]
        public void Member_Reposiroty_GetAll()
        {
            var result = repo.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[MemberRepository]Get By Id")]
        public void Member_Reposiroty_Get_By_Id()
        {
            var member = repo.GetById(10);
            Assert.True(member != null);
        }


        [Fact(DisplayName = "[MemberRepository]Insert")]
        public void Member_Repository_Insert()
        {
            var member = GetNewMember();
            var result = repo.Insert(member);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "[MemberRepository]Delete")]
        public void Member_Repository_Delete()
        {
            var member = GetNewMember();
            var result = repo.Insert(member);
            Assert.True(repo.Delete(member));
        }

        [Fact(DisplayName = "[MemberRepository]Update")]
        public void Member_Repository_Update()
        {
            var member = repo.GetById(10);
            Assert.True(member != null);
            Assert.True(repo.Update(member));
        }

        private Member GetNewMember()
        {
            return new Member
            {
                member_no=1,
                lastname="",
                firstname = "",
                middleinitial = "",
                street = "",
                city = "",
                state_prov = "",
                country = "",
                mail_code = "",
                phone_no = "",
                issue_dt = DateTime.Now,
                expr_dt = DateTime.Now,
                corp_no = 1,
                prev_balance = 0.00,
                curr_balance = 0.00,
                member_code = ""
            };
        }

    }
}
