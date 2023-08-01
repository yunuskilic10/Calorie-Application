using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DtoClass
{
    public class TotalCaloriesByCategoryDTO : IEnumerable
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public decimal Meyveler { get; set; }
        public decimal Sebzeler { get; set; }
        public decimal SutUrunleri { get; set; }
        public decimal EtveEtÜrünleri { get; set; }
        public decimal Tatlilar { get; set; }
        public decimal Tahillar { get; set; }
        public decimal Cerezler { get; set; }
        public decimal Icecekler { get; set; }
        public decimal UnluMamuller { get; set; }

        public IEnumerator GetEnumerator()
        {
            List<decimal> decimals = new List<decimal>() { Meyveler, Sebzeler, SutUrunleri, EtveEtÜrünleri, Tatlilar, Tahillar, Cerezler, Icecekler, UnluMamuller };
            return decimals.GetEnumerator();
        }
    }
}
