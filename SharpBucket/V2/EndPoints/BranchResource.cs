﻿using SharpBucket.V2.Pocos;
using System.Collections.Generic;

namespace SharpBucket.V2.EndPoints
{
    public class BranchResource
    {
        private readonly string _accountName;
        private readonly string _repository;
        private readonly RepositoriesEndPoint _repositoriesEndPoint;

        /// <summary>
        /// Manage branches for a repository. Use this resource to perform CRUD (create/read/update/delete) operations. 
        /// More info:
        /// https://developer.atlassian.com/bitbucket/api/2/reference/resource/repositories/%7Busername%7D/%7Brepo_slug%7D/refs/branches
        /// </summary>
        /// <returns></returns>
        public BranchResource(string accountName, string repository, RepositoriesEndPoint repositoriesEndPoint)
        {
            _accountName = accountName;
            _repository = repository;
            _repositoriesEndPoint = repositoriesEndPoint;
        }

        /// <summary>
        /// Lists all branches associated with a specific repository.
        /// </summary>
        /// <param name="max">The maximum number of items to return. 0 returns all items.</param>
        /// <returns></returns>
        public List<Branch> ListBranches(int max = 0) => ListBranches(null, max);

        /// <summary>
        /// Lists all branches associated with a specific repository.
        /// </summary>
        /// <param name="filter">The filter string to apply to the query.</param>
        /// <param name="max">The maximum number of items to return. 0 returns all items.</param>
        /// <returns></returns>
        public List<Branch> ListBranches(string filter, int max = 0)
        {
            return _repositoriesEndPoint.ListBranches(_accountName, _repository, filter, max);
        }
    }
}