using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {

        SqlConnection connection = new SqlConnection("Data Source= localhost ;Initial Catalog=AssessmentDB ;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand command;
        DataTable dt;

        public int InsertUser(Users users)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_InsertUser", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", users.Name);
            command.Parameters.AddWithValue("@Surname", users.Surname);
            command.Parameters.AddWithValue("@Email", users.Email);
            command.Parameters.AddWithValue("@UserStatus", users.UserStatus);
            command.Parameters.AddWithValue("@Password", users.Password);
            command.Parameters.AddWithValue("@Role", users.Role);
            command.Parameters.AddWithValue("@Title", users.Title);
            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;

        }
        public DataTable LoginUser(Users person)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_Login", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", person.Email);
            command.Parameters.AddWithValue("@Password", person.Password);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }
        public DataTable SearchUser(Users users)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_SearchUser", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Role", users.Role);

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable SearchUserByName(Users users)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_SearchUserByName", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", users.Name);
            command.Parameters.AddWithValue("@Surname", users.Surname);

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable ListAllUsers()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_ListUsers", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int InsertModule(Module module)//inserts module to DB
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_AddModule", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleName", module.ModuleDesc);
            command.Parameters.AddWithValue("@ModuleDuration", module.ModuleDuration);
            command.Parameters.AddWithValue("@ModuleTypeID", module.ModuleTypeID);

            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;

        }
        public int InsertAssessment(Assessment assessment)//inserts assessment to DB
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_AddAssessment", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AssessmentStatus", assessment.AssessmentStatus);
            command.Parameters.AddWithValue("@AssessmentTypeID", assessment.AssessmentTypeID);
            command.Parameters.AddWithValue("@ModuleID", assessment.ModuleID);
            command.Parameters.AddWithValue("@DueDate", assessment.DueDate);
            command.Parameters.AddWithValue("@AssessmentDescription", assessment.AssessmentDescription);

            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;
        }
        public DataTable ListModules(Module module)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_ListModules", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable ListAssessments(Assessment assessment)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_ListAssessments", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable LoadModuleType()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            command = new SqlCommand("sp_LoadModuleType", connection);
            command.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public int DeleteModule(Module module)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            command = new SqlCommand("sp_DeleteModule", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ModuleID", module.ModuleID);


            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;
        }
        public DataTable LoadLecturer()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_LoadLecturer", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int AssignLecturer(LecturerModule lecturer)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_AssignLecturer", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", lecturer.UserID);
            command.Parameters.AddWithValue("@ModuleID", lecturer.ModuleID);
            command.Parameters.AddWithValue("@Date", lecturer.Date);

            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;
        }
        public DataTable ListLecturers()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_ListModLecturer", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int UpdateUser(Users users)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_UpdateUser", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserStatus", users.UserStatus);
            command.Parameters.AddWithValue("@UserID", users.UserID);


            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;
        }

        public DataTable LoadAllStudents()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_LoadStudents", connection);
            command.CommandType = CommandType.StoredProcedure;

            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable LoadModLecturers(LecturerModule lecturerModule)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_ListModLecturer", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable LoadAssessmentType()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_LoadAssessmentType", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable SelectAssessments()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            command = new SqlCommand("sp_SelectAssessments", connection);
            command.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;

        }
        public DataTable SearchStatus(Assessment assess)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }

            command = new SqlCommand("sp_SearchStudentByStatus1", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AssessmentStatus", assess.AssessmentStatus);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }
        public DataTable SearchByID(int UserID)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            command = new SqlCommand("sp_SearchID", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", UserID);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public int UpdateStudent(Assessment assess)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {

            }
            command = new SqlCommand("sp_UpdateStudent", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DueDate", assess.DueDate);
            command.Parameters.AddWithValue("@AssessmentStatus", assess.AssessmentStatus);
            command.Parameters.AddWithValue("@AssessmentID", assess.AssessmentID);
            int x = command.ExecuteNonQuery();
            //connection.Close();
            return x;
        }
        public DataTable GetAssessmentType(Assessment assess)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            command = new SqlCommand("sp_GetAssessmentByType", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AssessmentTypeID", assess.AssessmentTypeID);

            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable LoadStudents()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_LoadStudents", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable ListModStudents(Module mod)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_ListModStudents", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleName",mod.ModuleDesc);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int AssignStudent(StudentModule student)
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_AssignStudents", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", student.UserID);
            command.Parameters.AddWithValue("@LecturerModuleID", student.LecturerModuleID);
            command.Parameters.AddWithValue("@Date", student.Date.ToString());

            int x = command.ExecuteNonQuery();
            connection.Close();
            return x;
        }
        public DataTable LoadThisLecturersMod()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {


            }
            command = new SqlCommand("sp_LoadThisLecModules", connection);
            command.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable Refresh(Module mod)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            command = new SqlCommand("sp_Refresh", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleName",mod.ModuleDesc);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
    }
}
