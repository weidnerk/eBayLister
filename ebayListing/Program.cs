using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebayListing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Displays Top Level Categories
                //eBayCategory.GetTopLevelCategories();

                // View all categories and IDs
                //eBayCategory.GetAllCategoriesRequest();

                // Verifies item then adds item to ebay.

                List<string> pictureURLs = new List<string>(){
                    "https://i.ebayimg.com/00/s/MTUwMFgxNTAw/z/ZJcAAOSwzE9a0Qpl/$_57.JPG",
                    "https://i.ebayimg.com/00/s/MTUwMFgxNTAw/z/6eQAAOSwER1a0Qpn/$_57.JPG",
                    "https://i.ebayimg.com/00/s/MTUwMFgxNTAw/z/YPIAAOSwb~Ja0Qpq/$_57.JPG",
                    "https://i.ebayimg.com/00/s/MTUwMFgxNTAw/z/zhsAAOSwLjRa0Qps/$_57.JPG",
                    "https://i.ebayimg.com/00/s/MTUwMFgxNTAw/z/f-8AAOSwF-Ja0Qpv/$_57.JPG",
                    "https://i.ebayimg.com/00/s/MTUwMFgxNTAw/z/kokAAOSwbLZa0Qpy/$_57.JPG",
                    "https://i.ebayimg.com/00/s/MTUwMFgxNTAw/z/aZkAAOSwlila0Qp0/$_57.JPG"
                };

                eBayItem.VerifyAddItemRequest("Guitar Strings Replacement Steel String for Acoustic Guitar 2 Sets of 6",
                    "Guitar Strings Replacement Steel String for Acoustic Guitar New Condition",
                    "308",    // DIY
                    1907.98,
                    pictureURLs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
