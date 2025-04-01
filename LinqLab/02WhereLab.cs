using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> WhereToGetIdBiggerThen8()
        {
            var result = Source.Where(s => s.Id > 8).ToList();
            return result;
        }

        public List<Sample> WhereToGetPrizeBiggerThen200()
        {
            var result = Source.Where(s => s.Price == 200).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameStartWithD()
        {
            var result = Source.Where(s => s.UserName.ToLower().StartsWith('d')).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameContainE()
        {
            var result = Source.Where(s => s.UserName.ToLower().Contains('e')).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameEndWithO()
        {
            var result = Source.Where(s => s.UserName.ToLower().EndsWith('o')).ToList();
            return result;
        }

        public List<Sample> WhereToGetUserNameEqualToDemoAndJoey()
        {
            var whereStr = new[] {"demo","joey" };
            var result = Source.Where(s => whereStr.Contains(s.UserName)).ToList();
            return result;
        }

        public bool WhereToCheckIsAnyIdEqualTo99()
        {
            var result = Source.Any(s => s.Id == 99);
            return result;
        }
    }
}
