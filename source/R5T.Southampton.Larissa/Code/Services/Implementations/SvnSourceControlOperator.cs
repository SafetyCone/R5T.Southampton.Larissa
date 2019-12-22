using System;

using Microsoft.Extensions.Logging;

using R5T.Larissa;


namespace R5T.Southampton.Larissa
{
    public class SvnSourceControlOperator : ISourceControlOperator
    {
        private ISvnOperator SvnOperator { get; }
        private ISvnversionOperator SvnversionOperator { get; }
        private ILogger Logger { get; }


        public SvnSourceControlOperator(ISvnOperator svnOperator, ISvnversionOperator svnversionOperator, ILogger<SvnSourceControlOperator> logger)
        {
            this.SvnOperator = svnOperator;
            this.SvnversionOperator = svnversionOperator;
            this.Logger = logger;
        }

        public void Add(string path)
        {
            this.SvnOperator.Add(path);
        }

        public void Checkout(string repositoryUrl, string localDirectoryPath)
        {
            this.SvnOperator.Checkout(repositoryUrl, localDirectoryPath);
        }

        public void CommitToRemote(string path, string message)
        {
            this.SvnOperator.Commit(path, message);
        }

        public string GetRemoteRepositoryUrl(string path)
        {
            throw new NotImplementedException();
        }

        public string GetRepositoryRootDirectoryPath(string path)
        {
            throw new NotImplementedException();
        }

        public bool IsUnderSourceControl(string path)
        {
            throw new NotImplementedException();
        }

        public void Update(string path)
        {
            throw new NotImplementedException();
        }

        public SourceControlOperatorInformation GetOperatorInformation()
        {
            var description = "SVN";
            var version = this.SvnOperator.GetVersion();

            var operatorInformation = new SourceControlOperatorInformation()
            {
                Description = description,
                Version = version,
            };

            return operatorInformation;
        }
    }
}
