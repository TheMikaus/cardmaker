using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// MIKAUS TODO: Delete all these later, this is the high level task list just sitting here because why not.
// - Project Manager needs to be able to Add a Project Localization
// - Project needs to be updated to know about Project Localization
// - Look at ProjectLayoutReference to see if we can rename it and use it here since they are going to act basically the same way on load
// - ProjectLocaliztaion needs to be updated to load it's dictionary properly
// - Test save/load of added localization files
// - Allow user to select a default localization lookup file to use.
// - Update column data return to use the localization lookup file if there is one
// - Update definitions to use the localization lookup file if there is one

namespace CardMaker.XML
{
    class ProjectLocalization
    {
        // MIKAUS TODO: Split into things that get serialized from the localization, and things that it stores.
        //            : 
        private Dictionary<string, string> m_dictionaryLocKeyToString = new Dictionary<string, string>();

        #region Properties
            // MIKAUS TODO: Can probably rename ProjectLayoutReference to ProjectFileReference
            [XmlElement("Reference")]
            public ProjectLayoutReference[] Reference { get; set; }
        #endregion

        ProjectLocalization()
        {
            // MIKAUS TODO: Should this be here? or should we only allow the creation of a localization with a file?
        }
    }
}
