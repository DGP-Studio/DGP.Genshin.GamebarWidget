using CommunityToolkit.Mvvm.ComponentModel;
using DGP.Genshin.GamebarWidget.Helper;
using DGP.Genshin.GamebarWidget.MiHoYoAPI;
using DGP.Genshin.GamebarWidget.Model;
using DGP.Genshin.GamebarWidget.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace DGP.Genshin.GamebarWidget.ViewModel
{
    internal class ResinViewModel : ObservableObject
    {
        private int displayIndex = 0;
        private RoleAndNote dailyNote;
        private ResinPage view;

        public RoleAndNote RoleAndNote { get => dailyNote; set => SetProperty(ref dailyNote, value); }
        public ResinPage View { get => view; set => SetProperty(ref view, value); }

        public List<RoleAndNote> RoleAndNotePool { get; set; }

        public ResinViewModel()
        {
            ContinuouslyRefreshDailyNotePool();
            ContinuouslySwitchDailyNote();
        }

        private async void ContinuouslySwitchDailyNote()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromSeconds(5));
                    await View?.Dispatcher.RunIdleAsync((e) => 
                    {
                        if (RoleAndNotePool?.Count > 0)
                        {
                            displayIndex++;
                            if (displayIndex >= RoleAndNotePool.Count)
                            {
                                displayIndex = 0;
                            }
                            RoleAndNote = RoleAndNotePool[displayIndex];
                        }
                    });
                }
            });//.ConfigureAwait(false);
        }

        private async void ContinuouslyRefreshDailyNotePool()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    await RefreshDailyNotePoolAsync();
                    await Task.Delay(TimeSpan.FromMinutes(8));
                }
            });//.ConfigureAwait(false);
        }

        private async Task RefreshDailyNotePoolAsync()
        {
            List<RoleAndNote> roleAndNotes = new List<RoleAndNote>();
            foreach (Cookie cookie in Setting.Cookies)
            {
                List<UserGameRole> roles = await new UserGameRoleProvider(cookie.CookieValue).GetUserGameRolesAsync();
                foreach (UserGameRole role in roles)
                {
                    DailyNote note = await new DailyNoteProvider(cookie.CookieValue).GetDailyNoteAsync(role.Region, role.GameUid);
                    roleAndNotes.Add(new RoleAndNote { Role = role, Note = note });
                }
            }
            RoleAndNotePool = roleAndNotes;
            displayIndex = 0;
        }
    }
}
