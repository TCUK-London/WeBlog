﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sitecore.Modules.WeBlog.Layouts
{
	public partial class Captcha : System.Web.UI.UserControl
	{
        protected void Page_Init(object sender, EventArgs e)
        {
            if (uxCaptchaCode != null)
            {
                uxCaptchaCode.CaptchaMaxTimeout = (int)Settings.CaptchaMaximumTimeout.TotalSeconds;
                uxCaptchaCode.CaptchaMinTimeout = (int)Settings.CaptchaMinimumTimeout.TotalSeconds;
            }
        }

        protected void uxCaptchaValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (uxCaptchaCode != null)
            {
                uxCaptchaCode.ValidateCaptcha(uxCaptchaText.Text);
                args.IsValid = uxCaptchaCode.UserValidated;
            }
        }

        protected void uxCaptchaCode_RefreshButtonClick(object sender, ImageClickEventArgs arg)
        {
            if (uxCaptchaText != null)
            {
                uxCaptchaText.Focus();
            }
        }
	}
}