﻿using Feature.FormsExtensions.XDb;
using Sitecore.XConnect.Collection.Model;

namespace Feature.FormsExtensions.Business.PrefillToken.xDbTokenHandlers.ContactPersonalInfo
{
    public class XDbSuffixTokenHandler : PersonalInformationTokenHandler
    {
        public XDbSuffixTokenHandler(IXDbService xDbService) : base(xDbService)
        {
        }
        
        protected override ITokenHandlerResult GetTokenValueFromFacet(PersonalInformation facet)
        {
            if (string.IsNullOrEmpty(facet.Suffix))
                return new NoTokenValueFoundResult();
            return new TokenValueFoundResult(facet.Suffix);
        }

        public override void StoreTokenValue(object newValue)
        {
            if (newValue is string suffix)
            {
                UpdateFacet(x => x.Suffix = suffix);
            }
        }
       
    }
}