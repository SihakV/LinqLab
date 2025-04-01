using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample FirstToGetUserNameEqualToDemo()
        {
            var result = Source.First(s => s.UserName == "demo");
            return result;
        }

        public Sample FirstOrDefaultToGetUserNameEuqalToSkilltree()
        {
            var result = Source.FirstOrDefault(s => s.UserName == "SkillTree");
            return result;
        }

        public Sample FirstToGetUserNameEuqalToSkilltree()
        {
            var result = Source.First(s => s.UserName == "SkillTree");
            return result;
        }

        public Sample SingleToGetUserNameEuqalToDemo()
        {
            var result = Source.Single(s => s.UserName == "Demo");
            return result;
        }

        public Sample SingleToGetUserNameEuqalToBill()
        {
            var result = Source.Single(s => s.UserName == "bill");
            return result;
        }
        public Sample SingleOrDefaultToGetUserNameEuqalToBill()
        {
            var result = Source.SingleOrDefault(s => s.UserName == "bill");
            return result;
        }

        public Sample SingleOrDefaultToGetUserNameEuqalToSkillTree()
        {
            var result = Source.SingleOrDefault(s => s.UserName == "SkillTree");
            return result;
        }
    }
}
