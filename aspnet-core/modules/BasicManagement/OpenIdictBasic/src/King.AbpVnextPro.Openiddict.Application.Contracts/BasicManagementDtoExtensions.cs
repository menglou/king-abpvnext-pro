﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace King.AbpVnextPro.Openiddict
{
    public class BasicManagementDtoExtensions
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                /* You can add extension properties to DTOs
                 * defined in the depended modules.
                 *
                 * Example:
                 *
                 * ObjectExtensionManager.Instance
                 *   .AddOrUpdateProperty<IdentityRoleDto, string>("Title");
                 *
                 * See the documentation for more:
                 * https://docs.abp.io/en/abp/latest/Object-Extensions
                 */
                ObjectExtensionManager.Instance
                  .AddOrUpdateProperty<string>(
                      new[]
                      {
                            typeof(IdentityUserDto),
                            typeof(IdentityUserCreateDto),
                            typeof(IdentityUserUpdateDto),
                            typeof(ProfileDto),
                            typeof(UpdateProfileDto)
                      },
                      "Avatar"
                  )
                  .AddOrUpdateProperty<string>(
                      new[]
                      {
                            typeof(IdentityUserDto),
                            typeof(IdentityUserCreateDto),
                            typeof(IdentityUserUpdateDto),
                            typeof(ProfileDto),
                            typeof(UpdateProfileDto)
                      },
                      "Introduction"
                  );
            });
        }
    }
}
