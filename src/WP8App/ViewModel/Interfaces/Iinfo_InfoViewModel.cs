// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	IViewModel.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// info_Info ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Iinfo_InfoViewModel
    {		
        /// <summary>
        /// Gets/Sets the Currentinfo_InfoHtmlControl property.
        /// </summary>
		string Currentinfo_InfoHtmlControl { get; set; }
        /// <summary>
        /// Gets/Sets the Bgkigallery_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Bgkigallery_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Selectedbgkigallery_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult Selectedbgkigallery_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Latesthairstyles_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Latesthairstyles_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Selectedlatesthairstyles_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult Selectedlatesthairstyles_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Makeuptutorials_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Makeuptutorials_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Selectedmakeuptutorials_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult Selectedmakeuptutorials_NewsListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the Refreshbgkigallery_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Refreshbgkigallery_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Getbgkigallery_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Getbgkigallery_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Refreshlatesthairstyles_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Refreshlatesthairstyles_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Getlatesthairstyles_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Getlatesthairstyles_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Refreshmakeuptutorials_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Refreshmakeuptutorials_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Getmakeuptutorials_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Getmakeuptutorials_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the TextToSpeechinfo_InfoHtmlControlCommand command.
        /// </summary>
		ICommand TextToSpeechinfo_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the Shareinfo_InfoHtmlControlCommand command.
        /// </summary>
		ICommand Shareinfo_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartinfo_InfoHtmlControlCommand command.
        /// </summary>
		ICommand PinToStartinfo_InfoHtmlControlCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}
