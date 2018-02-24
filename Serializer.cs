using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Classes
{
    public class Serializer
    {
        #region Subjects
        public string SubURL { get; set; }
        public bool CreateSubject(Subject s)
        {
            List<Subject> subs = GetSubject();
            subs.Add(s);
            XmlSerializer formatter = new XmlSerializer(typeof(Subject));
            try
            {
                using (FileStream fs = new FileStream(SubURL, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, s);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Subject> GetSubject()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Subject));
            List<Subject> s = new List<Subject>();
            FileInfo fi = new FileInfo(SubURL);
            if (fi.Exists)
            {
                using (FileStream fs = new FileStream(SubURL, FileMode.OpenOrCreate))
                {
                    s = (List<Subject>)formatter.Deserialize(fs);
                }
            }
            return s == null ? new List<Subject>() : s;
        }

        #endregion

        #region Users
        public string UserURL { get; set; }
        public bool CreateUser(User u)
        {
            List<User> subs = GetUser();
            subs.Add(u);
            XmlSerializer formatter = new XmlSerializer(typeof(User));
            try
            {
                using (FileStream fs = new FileStream(UserURL, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, u);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<User> GetUser()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(User));
            List<User> u = new List<User>();
            FileInfo fi = new FileInfo(UserURL);
            if (fi.Exists)
            {
                using (FileStream fs = new FileStream(UserURL, FileMode.OpenOrCreate))
                {
                    u = (List<User>)formatter.Deserialize(fs);
                }
            }
            return u == null ? new List<User>() : u;
        }
        #endregion

        #region CheckLists
        public string CKURL { get; set; }
        public bool CreateCK(CheckList ck)
        {
            List<CheckList> subs = GetCK();
            subs.Add(ck);
            XmlSerializer formatter = new XmlSerializer(typeof(CheckList));
            try
            {
                using (FileStream fs = new FileStream(CKURL, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, ck);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CheckList> GetCK()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(CheckList));
            List<CheckList> ck = new List<CheckList>();
            FileInfo fi = new FileInfo(CKURL);
            if (fi.Exists)
            {
                using (FileStream fs = new FileStream(CKURL, FileMode.OpenOrCreate))
                {
                    ck = (List<CheckList>)formatter.Deserialize(fs);
                }
            }
            return ck == null ? new List<CheckList>() : ck;
        }
        #endregion

        #region Automobiles
        public string AURL { get; set; }
        public bool CreateAuto(Automobile a)
        {
            List<Automobile> subs = GetAuto();
            subs.Add(a);
            XmlSerializer formatter = new XmlSerializer(typeof(Automobile));
            try
            {
                using (FileStream fs = new FileStream(AURL, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, a);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Automobile> GetAuto()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Automobile));
            List<Automobile> a = new List<Automobile>();
            FileInfo fi = new FileInfo(AURL);
            if (fi.Exists)
            {
                using (FileStream fs = new FileStream(AURL, FileMode.OpenOrCreate))
                {
                    a = (List<Automobile>)formatter.Deserialize(fs);
                }
            }
            return a == null ? new List<Automobile>() : a;
        }
        #endregion

    }
}

