using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        public ActionResult Index()
        {
            // Get the list of users from the userlist
            var users = userlist;

            // Return the users to the Index view
            return View(users);
        }
 
      // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // Find the user with the specified ID in the userlist
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If user is found, return the Details view with the user as the model
            if (user != null)
            {
                return View(user);
            }

            // If no user is found, return a HttpNotFoundResult
            return HttpNotFound();
        }
 
      // GET: User/Create
        public ActionResult Create()
        {
            //Implement the Create method here
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            // Add the user to the userlist
            userlist.Add(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }
 
      // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // Find the user with the specified ID in the userlist
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If user is found, pass it to the Edit view
            if (user != null)
            {
                return View(user);
            }

            // If no user is found, return a HttpNotFoundResult
            return HttpNotFound();
        }
 
      // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            // Find the user with the specified ID in the userlist
            var existingUser = userlist.FirstOrDefault(u => u.Id == id);

            // If user is found, update the user's information
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction("Index");
            }

            // If no user is found, return a HttpNotFoundResult
            return HttpNotFound();
        }
 
      // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Find the user with the specified ID in the userlist
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If user is found, return the Delete view with the user as the model
            if (user != null)
            {
                return View(user);
            }

            // If no user is found, return a HttpNotFoundResult
            return HttpNotFound();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Find the user with the specified ID in the userlist
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If user is found, remove the user from the userlist
            if (user != null)
            {
                userlist.Remove(user);

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction("Index");
            }

            // If no user is found, return a HttpNotFoundResult
            return HttpNotFound();
        }
    }
}
