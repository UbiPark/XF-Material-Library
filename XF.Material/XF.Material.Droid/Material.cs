﻿using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Linq;

namespace XF.Material.Droid
{
    public static class Material
    {
        public static Context Context { get; private set; }

        public static bool IsLollipop { get; private set; }

        public static void Init(Context context, Bundle bundle)
        {
            Context = context;
            IsLollipop = Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop;

            AppCompatDelegate.CompatVectorFromResourcesEnabled = true;
            Rg.Plugins.Popup.Popup.Init(context, bundle);
        }

        public static void HandleBackButton(Action backAction)
        {
            var materialDialog = PopupNavigation.Instance.PopupStack.FirstOrDefault(p => p is XF.Material.Dialogs.MaterialDialog);
            var loadingDialog = PopupNavigation.Instance.PopupStack.FirstOrDefault(p => p is XF.Material.Dialogs.MaterialLoadingDialog);

            if (Popup.SendBackPressed(backAction) && materialDialog != null && loadingDialog == null)
            {
                PopupNavigation.Instance.RemovePageAsync(materialDialog);
            }

            else if (Popup.SendBackPressed(backAction) && materialDialog == null && loadingDialog == null)
            {
                backAction?.Invoke();
            }
        }
    }
}