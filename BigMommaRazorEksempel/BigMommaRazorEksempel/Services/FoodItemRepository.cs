using System.Text;
using BigMommaRazorEksempel.model;

namespace BigMommaRazorEksempel.Services
{
    public class FoodItemRepository
    {
        // instans felt
        Dictionary<int, FoodItem> _katalog;

        // properties
        public Dictionary<int, FoodItem> Katalog
        {
            get { return _katalog; }
            set { _katalog = value; }
        }

        // konstruktør
        public FoodItemRepository(bool mockData = false)
        {
            _katalog = new Dictionary<int, FoodItem>();


            if (mockData)
            {
                PopulateKundeRepository();
            }
        }

        private void PopulateKundeRepository()
        {
            _katalog.Clear();

            _katalog.Add(1, new FoodItem("Pizza", "Hawaii", 20));
            _katalog.Add(2, new FoodItem("Drink", "Faxe Kondi", 10));
        }


        /*
         * metoder
         */
        public FoodItem Tilføj(FoodItem item)
        {
            _katalog.Add(item.Id, item);

            return item;
        }

        public FoodItem Slet(int id)
        {
            if (_katalog.ContainsKey(id))
            {
                FoodItem slettetItem = _katalog[id];
                _katalog.Remove(id);
                return slettetItem;

            }
            else
            {
                return null;
            }
        }

        public FoodItem HentItem(int id)
        {
            if (_katalog.ContainsKey(id))
            {
                return _katalog[id];

            }
            else
            {
                // opdaget en fejl
                throw new KeyNotFoundException("id findes ikke");



                //return null;
            }
        }

        public List<FoodItem> HentAlleKunder()
        {
            return _katalog.Values.ToList();
        }

        public FoodItem HentKundeUdFraDsc(string dsc)
        {
            FoodItem resKunde = null;

            foreach (FoodItem k in _katalog.Values)
            {
                if (k.Description == dsc)
                {
                    return k;
                }
            }

            return resKunde;
        }

        public override string ToString()
        {
            String pænTekst = String.Join(", ", _katalog.Values);

            return $"{{{nameof(Katalog)}={pænTekst}}}";
        }
    }
}
