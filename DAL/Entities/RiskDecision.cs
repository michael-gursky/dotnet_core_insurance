﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class RiskDecision
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        public String DecisionDescription { get; set; }

        [Required]
        public Double EvaluaetedRiskDamage { get; set; }

        [Required]
        public Double EvaluatedDamageChance { get; set; }

        [Required]
        public Double EvaluatedInsuranceFee { get; set; }

        [ForeignKey(nameof(Application))]
        public Int64 Application { get; set; }
    }
}