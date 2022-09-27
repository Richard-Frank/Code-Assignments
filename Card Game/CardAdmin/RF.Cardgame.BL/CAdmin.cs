using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF.Cardgame.PL;

namespace RF.Cardgame.BL
{
    public class CAdmin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public CAdmin()
        {

        }

        // overloaded constructor
        public CAdmin(Guid id, string name, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
        }

        // overloaded constructor for login
        public CAdmin(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public CAdmin(Guid id)
        {
            this.Id = id;
        }

        // insert method
        public void Insert()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                tblAdmin admin = new tblAdmin();
                admin.Id = Guid.NewGuid();
                admin.Name = this.Name;
                admin.Password = this.Password;



                this.Id = admin.Id;

                oDc.tblAdmins.InsertOnSubmit(admin);
                oDc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        // update method
        public void Update()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var admin = oDc.tblAdmins.Where(p => p.Id == Id).FirstOrDefault();

                if (admin != null)
                {

                    admin.Name = this.Name;
                    admin.Password = this.Password;

                    oDc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // delete method
        public void Delete()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var admin = oDc.tblAdmins.Where(p => p.Id == Id).FirstOrDefault();

                if (admin != null)
                {
                    oDc.tblAdmins.DeleteOnSubmit(admin);
                    oDc.SubmitChanges();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // load by id
        public void LoadById()
        {
            try
            {
                // data context oDc
                CardGameDataContext oDc = new CardGameDataContext();

                var admin = oDc.tblAdmins.Where(p => p.Id == Id).FirstOrDefault();

                // set the properties
                this.Id = admin.Id;
                this.Name = admin.Name;
                this.Password = admin.Password;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

      

        // login and test
        public bool Login()
        {
            try
            {
                if (Name != string.Empty)
                {
                    if (Password != string.Empty)
                    {
                        // get the user info out of the database
                        CardGameDataContext oDc = new CardGameDataContext();

                        tblAdmin otblAdmin = oDc.tblAdmins.FirstOrDefault(u => u.Name == Name);

                        if (otblAdmin != null)
                        {
                            if (otblAdmin.Password == Password)
                            {
                                // successful login
                                Id = otblAdmin.Id;
                                Name = otblAdmin.Name;
                                
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        throw new Exception("Pasword needs to be set.");
                    }
                }
                else
                {
                    throw new Exception("Username needs to be set.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }



    // make a list class
    public class CAdminList : List<CAdmin>
    {
        // Load Method
        public void Load()
        {
            try
            {
                // data context
                CardGameDataContext oDc = new CardGameDataContext();

                var results = (from c in oDc.tblAdmins
                               select c).ToList();
                foreach (var admin in results)
                {
                    CAdmin oAdmin = new CAdmin(admin.Id, admin.Name, admin.Password);

                    Add(oAdmin);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
