using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using DapperUi.Models;

namespace DapperUi.Controllers
{
    public class StudController : Controller
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["hi"].ConnectionString);
        int id1;
        // GET: Stud
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(int id)
        {
            Student stud=db.QueryFirstOrDefault<Student>("EmployeeGet ", new { id = id }, commandType: CommandType.StoredProcedure);
           
            if(stud!=null)
            {
                return View(stud);

            }
            else
            {
                stud = new Student();
                stud.Id = -1;
                return View(stud);
            }
            
        }
        public ActionResult StudTable()
        {
            List<Student> students = new List<Student>();
            students=db.Query<Student>("StudentList", commandType: CommandType.StoredProcedure).ToList();
            return View(students);
        }
        public void Retur(int id)
        {
            id1 = id;
        }
       public ActionResult OutputReturn()
        {
           int id = 2;
            ViewBag.find=db.QueryFirstOrDefault<int>("CheckEmployeeId ", new { Id = id }, commandType: CommandType.StoredProcedure);
            return View();
        }
        public ActionResult MultiList()
        {
            List<StudentSub> students = new List<StudentSub>();

            students = db.Query<StudentSub>("JoinStudent", commandType: CommandType.StoredProcedure).ToList();
            return View(students);

        }
    }
}