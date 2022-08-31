using Microsoft.AspNetCore.Components;
using PINProjekt.Data;
using PINProjekt.Entiteti;

namespace UserInfoBE
{
    public class UserInfoBE : ComponentBase
    {
        public UserInfo? UserInfo
        {
            get;
            set;
        }
        protected override Task OnInitializedAsync()
        {
            UserInfo = new UserInfo();
            return base.OnInitializedAsync();
        }
        public void SpremiInfoKorisnika()
        {
            using (Data data = new Data())
            {
                data.SpremiInfoKorisnika(UserInfo);
            }
        }
    }
}
