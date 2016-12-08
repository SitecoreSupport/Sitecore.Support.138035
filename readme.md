# Sitecore.Support.138035
`Media Link` specified in the `General Link` field is rendered without the `la` query string parameter.<br/>
The issue happens because the `Sitecore.Resources.Media.MediaProvider.GetMediaUrl` method (which is used to get `Media Link`) doesn’t consider the context language.<br/>
This patch overrides the described method in order to add the `la` query string parameter to `Media Link` if the `languageEmbedding` attribute is not set to `never` for `Link Provider` in the `\Website\App_Config\Sitecore.config` file.

## License  
This patch is licensed under the [Sitecore Corporation A/S License for GitHub](https://github.com/sitecoresupport/Sitecore.Support.138035/blob/master/LICENSE).  

## Download  
Downloads are available via [GitHub Releases](https://github.com/sitecoresupport/Sitecore.Support.138035/releases).  
