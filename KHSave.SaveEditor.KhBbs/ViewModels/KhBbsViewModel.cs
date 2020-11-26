using KHSave.LibBbs;
using KHSave.SaveEditor.Common.Contracts;
using KHSave.SaveEditor.Common.Exceptions;
using System.IO;
using Xe.Tools;

namespace KHSave.SaveEditor.KhBbs.ViewModels
{
    public class KhBbsViewModel : BaseNotifyPropertyChanged, IRefreshUi, IOpenStream, IWriteToStream
    {
        private ISaveKhBbs save;

        public SystemViewModel System { get; set; }
        public CharacterViewModel Character { get; set; }
        public CommandListViewModel CommandList { get; set; }
        public DecksViewModel Decks { get; set; }

        public void RefreshUi()
        {
            System = new SystemViewModel(save);
            Character = new CharacterViewModel(save.Character);
            CommandList = new CommandListViewModel(save.CommandList);
            Decks = new DecksViewModel(save.Decks, CommandList);

            OnPropertyChanged(nameof(System));
            OnPropertyChanged(nameof(Character));
            OnPropertyChanged(nameof(CommandList));
            OnPropertyChanged(nameof(Decks));
        }

        public void OpenStream(Stream stream)
        {
            switch (SaveKhBbs.GetGameVersion(stream))
            {
                case GameVersion.FinalMix:
                    save = SaveKhBbs.Read<SaveKhBbs.SaveFinalMix>(stream);
                    break;
                default:
                    throw new SaveNotSupportedException("The version is not supported.");
            }
            RefreshUi();
        }

        public void WriteToStream(Stream stream) => SaveKhBbs.Write(stream, save);
    }
}
