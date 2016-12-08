using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.IO;
using Sitecore.Links;
using Sitecore.Resources.Media;
using Sitecore.Web;
using System;
using System.Web;
using System.Xml;

namespace Sitecore.Support.Resources.Media
{
    public class MediaProvider : Sitecore.Resources.Media.MediaProvider
    {
        public override string GetMediaUrl(MediaItem item)
        {
            Assert.ArgumentNotNull(item, "item");
            MediaUrlOptions options = MediaUrlOptions.Empty;
            if (LinkManager.LanguageEmbedding != LanguageEmbedding.Never)
            {
                options.Language = Context.Language;
                return this.GetMediaUrl(item, options);
            }
            return this.GetMediaUrl(item, options);
        }
    }
}