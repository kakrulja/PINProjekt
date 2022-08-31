using PINProjekt.Entiteti;

namespace PINProjekt.Data
{
    public class Data : IDisposable
    {
        public void Dispose() 
        { 
        }
        public void SpremiInfoKorisnika(UserInfo userInfo)
        {
            using (DbProjekt DB=new DbProjekt())
            {
                DB.UserInfos.Add(userInfo);
                DB.SaveChanges();
            }
        }
    }
}
