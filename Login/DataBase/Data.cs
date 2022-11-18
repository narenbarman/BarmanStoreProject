
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BarmanStoreProject;
using BarmanStoreProject.BARMANSTOREDATABASEDataSetTableAdapters;
using System.Windows.Forms;

namespace BarmanStoreProject
{
    internal class Data
    {
        private static BARMANSTOREDATABASEDataSet.USERACCOUNTTABLEDataTable mytable;
        private static USERACCOUNTTABLETableAdapter myadapter;
        internal static void DeleteAccount(string activeUser)
        {
            try
            {
                myadapter = new USERACCOUNTTABLETableAdapter();
                myadapter.DeleteRecordQuery(activeUser);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally {
                myadapter = null;
            }   
        }

        internal static int InsertRecord(string fname, string lname, string mname, string sex, string dob, string contact, string email, string address, string uname, string password)
        {
            int count=0;
            try
            {
                myadapter = new USERACCOUNTTABLETableAdapter();
                count = myadapter.InsertRecordQuery(uname, password, fname, lname, mname, sex,dob, contact, email, address);
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return count;
            }
            finally
            {
                myadapter = null;
                
            }
        }

        internal static bool LoginValidated(string username, string password)
        {
            try
            {
                myadapter = new USERACCOUNTTABLETableAdapter();
                mytable = new BARMANSTOREDATABASEDataSet.USERACCOUNTTABLEDataTable();
                myadapter.FillByUserName(mytable, username);
                bool ans = mytable.Rows[mytable.Rows.Count - 1]["usertype"] + "" == "ADMIN";
                if (mytable.Rows.Count > 0 && mytable.Rows[mytable.Rows.Count - 1]["PASSWORD"] + "" == password)
                {
                    switch (mytable.Rows[mytable.Rows.Count - 1]["USERTYPE"] )
                    {

                        case "USER":
                            Views.Usernview();
                            return true;

                        case "ADMIN":
                            Views.Adminview();
                            return true;
                        default:
                            Views.Usernview();
                            return true;
                            
                    }
                    
                }
                else return false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                myadapter = null;
                mytable = null;
            }
            
            
        }

        internal static bool NewUserNameAvailable(string username)
        {
            try
            {
                myadapter = new USERACCOUNTTABLETableAdapter();
                mytable = new BARMANSTOREDATABASEDataSet.USERACCOUNTTABLEDataTable();
                myadapter.FillByUserName(mytable,username);
                if (mytable.Rows.Count > 0) { return true; }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                myadapter = null;
                mytable= null;
            }
        }

        internal static bool PasswordValidated(string username,string password)
        {
            try
            {
                myadapter = new USERACCOUNTTABLETableAdapter();
                mytable = new BARMANSTOREDATABASEDataSet.USERACCOUNTTABLEDataTable();
                myadapter.FillByUserName(mytable, username);
                if (mytable.Rows.Count > 0 && mytable.Rows[mytable.Rows.Count - 1]["PASSWORD"]+""==password) return true; 
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                myadapter = null;
                mytable = null;
            }
        }

        internal static int UpdatePassword(string username,string password)
        {
            try
            {
                myadapter = new USERACCOUNTTABLETableAdapter();
                MessageBox.Show(myadapter.UpdatePasswordQuery(password,username)+username+password);
                return myadapter.UpdatePasswordQuery(password,username);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                myadapter = null;
            }
        }
    }
}
