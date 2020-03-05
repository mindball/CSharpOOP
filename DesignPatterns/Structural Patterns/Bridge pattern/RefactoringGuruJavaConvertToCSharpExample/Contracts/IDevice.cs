namespace RefactoringGuruJavaConvertToCSharpExample.Contracts
{
    public interface IDevice
    {
        bool IsEnabled();

        void Enable();

        void Disable();

        int GetVolume();

        void SetVolume(int percent);

        int GetChannel();

        void SetChannel(int channel);

        void PrintStatus();

        void Mode();
    }
}
