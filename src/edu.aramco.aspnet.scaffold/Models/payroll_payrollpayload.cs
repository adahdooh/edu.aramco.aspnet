using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class payroll_payrollpayload
{
    public int id { get; set; }

    public DateTime? calc_time { get; set; }

    public double? basic_salary { get; set; }

    public DateTime? effective_date { get; set; }

    public string? format_dict { get; set; }

    public short? payment_mode { get; set; }

    public double? increase { get; set; }

    public double? deduction { get; set; }

    public string? increase_formula { get; set; }

    public string? deduction_formula { get; set; }

    public string? increase_formula_name { get; set; }

    public string? deduction_formula_name { get; set; }

    public double? extra_increase { get; set; }

    public double? extra_deduction { get; set; }

    public double? total_loan_amount { get; set; }

    public double? refund_loan_amount { get; set; }

    public double? unrefund_loan_amount { get; set; }

    public double? loan_deduction { get; set; }

    public double? loan_increase { get; set; }

    public double? advance_increase { get; set; }

    public double? advance_deduction { get; set; }

    public double? reimbursement { get; set; }

    public string? total_increase_formula { get; set; }

    public string? total_increase_formula_name { get; set; }

    public string? total_increase_expression { get; set; }

    public double? total_increase { get; set; }

    public string? total_deduction_formula { get; set; }

    public string? total_deduction_formula_name { get; set; }

    public string? total_deduction_expression { get; set; }

    public double? total_deduction { get; set; }

    public string? total_salary_expression { get; set; }

    public double? total_salary { get; set; }

    public int employee_id { get; set; }

    public virtual personnel_employee employee { get; set; } = null!;

    public virtual ICollection<payroll_payrollpayloadpaycode> payroll_payrollpayloadpaycodes { get; set; } = new List<payroll_payrollpayloadpaycode>();
}
