﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ProjectProposal> ProjectProposals { get; set; } = new List<ProjectProposal>();
        public ICollection<ApprovalRule> ApprovalRules { get; set; } = new List<ApprovalRule>();

    }
}
