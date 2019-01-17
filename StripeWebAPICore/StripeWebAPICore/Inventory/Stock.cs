using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeWebAPICore.Inventory
{
    public class Stock
    {
        public Stock()
        {
            ShirtsForSale = new List<TShirt>
            {
                new TShirt{ Name = "Family Vacation", Image = "https://scontent.fric1-2.fna.fbcdn.net/v/t1.0-9/36229586_1692401984142547_653772500093632512_n.jpg?_nc_cat=105&_nc_ht=scontent.fric1-2.fna&oh=6fb60eb6b93fa1dce7b54f544c6d416d&oe=5CC2044B", Price = 2000},
                new TShirt{ Name = "Outlander", Image = "https://scontent.fric1-1.fna.fbcdn.net/v/t1.0-9/25659376_1504472726268808_8756861083457791754_n.jpg?_nc_cat=107&_nc_ht=scontent.fric1-1.fna&oh=68a24e38a64d9bb430cee9ffeb060337&oe=5CC4D99D", Price = 2000},
                new TShirt{ Name = "Work Polo", Image = "https://scontent.fric1-1.fna.fbcdn.net/v/t1.0-9/20292681_1371067769609305_3537954049653991528_n.jpg?_nc_cat=108&_nc_ht=scontent.fric1-1.fna&oh=722d1cfbd1ee746d9161843379a21c33&oe=5CD3FB65", Price = 2000},
                new TShirt{ Name = "Conjoined Triangles of Success", Image = "https://scontent.fric1-2.fna.fbcdn.net/v/t1.0-9/20106402_1364227210293361_4654745697704058851_n.jpg?_nc_cat=103&_nc_ht=scontent.fric1-2.fna&oh=92f212f91cb19b2249a476fc09373993&oe=5CC0C6F0", Price = 2000},
                new TShirt{ Name = "Pied Piper", Image = "https://scontent.fric1-1.fna.fbcdn.net/v/t1.0-9/19146028_1332114023504680_349708346493723056_n.jpg?_nc_cat=100&_nc_ht=scontent.fric1-1.fna&oh=a52ab94f7f4c40d5055656f3343e5b4b&oe=5CB9E0CF", Price = 2000}
            };
        }

        public List<TShirt> ShirtsForSale;
    }
}
