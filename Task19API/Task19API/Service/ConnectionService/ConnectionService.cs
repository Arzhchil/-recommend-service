﻿using Task19API.Interface;

namespace Task19API.Service.ConnectionService
{
    public static class ConnectionService
    {
        /// <summary>
        /// прописывается создание сервисов
        /// </summary>
        /// <param name="builder"></param>
        public static void ConnectService(WebApplicationBuilder builder)
        {
            //builder.Services.AddTransient<ITutorialInterface, TutorialService>();
            builder.Services.AddTransient<IUser, UserIdentifyService>();
            builder.Services.AddTransient<IUserGroups, UserGroupsService>();
            builder.Services.AddTransient<IUnique, UniqueService>();
        }
    }
}
