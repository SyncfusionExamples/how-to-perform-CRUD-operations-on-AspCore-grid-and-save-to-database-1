using Syncfusion.EJ2.Base;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
namespace WebApp.Controllers
{
  public class DataGridController : Controller
  {
	    private OrderDbContext _context;

		public DataGridController(OrderDbContext Context)
		{
            this._context=Context;
		}
        public ActionResult Index()
        {
	        return View();
        }
        public ActionResult UrlDatasource([FromBody]DataManagerRequest dm)
        {

            IEnumerable DataSource = _context.Orders.ToList();

            DataOperations operation = new DataOperations();
            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting
            {
                DataSource = operation.PerformSorting(DataSource, dm.Sorted);
            }
            int count = DataSource.Cast<Orders>().Count();
            if (dm.Skip != 0)//Paging
            {
                DataSource = operation.PerformSkip(DataSource, dm.Skip);         
            }
            if (dm.Take != 0)
            {
                DataSource = operation.PerformTake(DataSource, dm.Take);
            }
           
            return Json(new { result = DataSource, count = count });
        }
        public ActionResult Insert([FromBody]CRUDModel<Orders>  value)
        {
            //do stuff
            _context.Orders.Add(value.Value);
            _context.SaveChanges();
            return Json(value);
        }
        public ActionResult Update([FromBody]CRUDModel<Orders>  value)
        {
            //do stuff
			var ord = value;

           Orders val = _context.Orders.Where(or => or.OrderID == ord.Value.OrderID).FirstOrDefault();
            val.OrderID=ord.Value.OrderID;
            val.CustomerID=ord.Value.CustomerID;
            _context.SaveChanges();
            return Json(value);
        }
        public ActionResult Delete([FromBody]CRUDModel<Orders> value)
        {

            //do stuff
            Orders order = _context.Orders.Where(c => c.OrderID == (int)value.Key).FirstOrDefault();
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return Json(order);
        }
   }
}