using System;

using R5T.Larissa;


namespace R5T.Southampton.Larissa
{
    public class SvnSourceControlOperator : ISourceControlOperator
    {
        private ISvnOperator SvnOperator { get; }


        public SvnSourceControlOperator(ISvnOperator svnOperator)
        {
            this.SvnOperator = svnOperator;
        }

        public void Add(string path)
        {
            throw new NotImplementedException();
        }

        public void Checkout(string repositoryUrl, string localDirectoryPath)
        {
            throw new NotImplementedException();
        }

        public void CommitToRemote(string path, string message)
        {
            throw new NotImplementedException();
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
    }
}
