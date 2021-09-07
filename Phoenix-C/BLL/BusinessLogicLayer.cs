using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BusinessLogicLayer
    {

        DataAccessLayer dal = new DataAccessLayer();

        public int InsertUsers(Users users)
        {
            return dal.InsertUser(users);
        }

        public DataTable Login(Users users)
        {
            return dal.LoginUser(users);
        }
        public DataTable SearchUser(Users users)
        {
            return dal.SearchUser(users);
        }
        public DataTable SearchUserByName(Users users)
        {
            return dal.SearchUserByName(users);
        }
        public DataTable ListAllUsers()
        {
            return dal.ListAllUsers();
        }
        public int InsertModule(Module module)
        {
            return dal.InsertModule(module);
        }
        public int InsertAssessment(Assessment assessment)
        {
            return dal.InsertAssessment(assessment);
        }
        public DataTable ListModules(Module module)
        {
            return dal.ListModules(module);
        }
        public DataTable ListAssessments(Assessment assessment)
        {
            return dal.ListAssessments(assessment);
        }
        public DataTable LoadModuleType()
        {
            return dal.LoadModuleType();
        }
        public int DeleteModule(Module module)
        {
            return dal.DeleteModule(module);
        }
        public DataTable Refresh(Module mod)
        {
            return dal.Refresh(mod);
        }
        public DataTable LoadLecturer()
        {
            return dal.LoadLecturer();
        }
        public int AssignLecturer(LecturerModule lecturer)
        {
            return dal.AssignLecturer(lecturer);
        }

        public DataTable ListModLecturer()
        {
            return dal.ListLecturers();
        }
        public int UpdateUsers(Users users)
        {
            return dal.UpdateUser(users);
        }

        public DataTable LoadAllStudents()
        {
            return dal.LoadAllStudents();
        }
        public DataTable loadModLect(LecturerModule lecturerModule)
        {
            return dal.LoadModLecturers(lecturerModule);
        }
        public DataTable SearchByID(int UserID)
        {
            return dal.SearchByID(UserID);
        }
        public DataTable SelectAssessments()
        {
            return dal.SelectAssessments();
        }
        public DataTable LoadAssessmentType()
        {
            return dal.LoadAssessmentType();
        }
        public DataTable SearchByStatus(Assessment assess)
        {
            return dal.SearchStatus(assess);
        }
        public int UpdateStudent(Assessment assess)
        {
            return dal.UpdateStudent(assess);
        }
        public DataTable GetAssessmentType(Assessment assess)
        {
            return dal.GetAssessmentType(assess);
        }
        public DataTable ListModStudents(Module mod)
        {
            return dal.ListModStudents(mod);
        }
        public DataTable loadStudents()
        {
            return dal.LoadStudents();
        }
        public int AssignStudent(StudentModule student)
        {
            return dal.AssignStudent(student);
        }
        public DataTable LoadThisLecModules()
        {
            return dal.LoadThisLecturersMod();
        }
    }
}
