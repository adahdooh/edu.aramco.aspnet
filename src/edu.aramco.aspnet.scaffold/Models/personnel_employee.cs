using System;
using System.Collections.Generic;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class personnel_employee
{
    public int id { get; set; }

    public DateTime? create_time { get; set; }

    public string? create_user { get; set; }

    public DateTime? change_time { get; set; }

    public string? change_user { get; set; }

    public short status { get; set; }

    public string? device_password { get; set; }

    public int? dev_privilege { get; set; }

    public string? card_no { get; set; }

    public string? acc_group { get; set; }

    public string? acc_timezone { get; set; }

    public string? enroll_sn { get; set; }

    public int? verify_mode { get; set; }

    public short? app_status { get; set; }

    public short? app_role { get; set; }

    public DateTime? last_login { get; set; }

    public bool is_active { get; set; }

    public string? session_key { get; set; }

    public string? login_ip { get; set; }

    public string emp_code { get; set; } = null!;

    public string? first_name { get; set; }

    public string? last_name { get; set; }

    public string? nickname { get; set; }

    public string? passport { get; set; }

    public string? driver_license_automobile { get; set; }

    public string? driver_license_motorcycle { get; set; }

    public string? photo { get; set; }

    public string? self_password { get; set; }

    public string? gender { get; set; }

    public DateTime? birthday { get; set; }

    public string? address { get; set; }

    public string? postcode { get; set; }

    public string? office_tel { get; set; }

    public string? contact_tel { get; set; }

    public string? mobile { get; set; }

    public string? national { get; set; }

    public string? religion { get; set; }

    public string? title { get; set; }

    public string? ssn { get; set; }

    public DateTime? update_time { get; set; }

    public DateTime? hire_date { get; set; }

    public string? city { get; set; }

    public short? emp_type { get; set; }

    public bool enable_payroll { get; set; }

    public string? email { get; set; }

    public int? leave_group { get; set; }

    public int? department_id { get; set; }

    public int? position_id { get; set; }

    public long? emp_code_digit { get; set; }

    public int? superior_id { get; set; }

    public int? company_id { get; set; }

    public virtual ICollection<personnel_employee> Inversesuperior { get; set; } = new List<personnel_employee>();

    public virtual ICollection<acc_accprivilege> acc_accprivileges { get; set; } = new List<acc_accprivilege>();

    public virtual att_attemployee? att_attemployee { get; set; }

    public virtual ICollection<att_attschedule> att_attschedules { get; set; } = new List<att_attschedule>();

    public virtual ICollection<att_leaveyearbalance> att_leaveyearbalances { get; set; } = new List<att_leaveyearbalance>();

    public virtual ICollection<att_payloadattcode> att_payloadattcodes { get; set; } = new List<att_payloadattcode>();

    public virtual ICollection<att_payloadbase> att_payloadbases { get; set; } = new List<att_payloadbase>();

    public virtual ICollection<att_payloadeffectpunch> att_payloadeffectpunches { get; set; } = new List<att_payloadeffectpunch>();

    public virtual ICollection<att_payloadmulpunchset> att_payloadmulpunchsets { get; set; } = new List<att_payloadmulpunchset>();

    public virtual ICollection<att_payloadparing> att_payloadparings { get; set; } = new List<att_payloadparing>();

    public virtual ICollection<att_payloadpaycode> att_payloadpaycodes { get; set; } = new List<att_payloadpaycode>();

    public virtual ICollection<att_payloadpunch> att_payloadpunches { get; set; } = new List<att_payloadpunch>();

    public virtual ICollection<att_payloadtimecard> att_payloadtimecards { get; set; } = new List<att_payloadtimecard>();

    public virtual ICollection<att_reporttemplate> att_reporttemplates { get; set; } = new List<att_reporttemplate>();

    public virtual ICollection<att_temporaryschedule> att_temporaryschedules { get; set; } = new List<att_temporaryschedule>();

    public virtual ICollection<att_tempschedule> att_tempschedules { get; set; } = new List<att_tempschedule>();

    public virtual personnel_company? company { get; set; }

    public virtual personnel_department? department { get; set; }

    public virtual ICollection<ep_eptransaction> ep_eptransactions { get; set; } = new List<ep_eptransaction>();

    public virtual ICollection<iclock_biodatum> iclock_biodata { get; set; } = new List<iclock_biodatum>();

    public virtual ICollection<iclock_biophoto> iclock_biophotos { get; set; } = new List<iclock_biophoto>();

    public virtual ICollection<iclock_privatemessage> iclock_privatemessages { get; set; } = new List<iclock_privatemessage>();

    public virtual ICollection<iclock_transaction> iclock_transactions { get; set; } = new List<iclock_transaction>();

    public virtual ICollection<meeting_meetingentity_attender> meeting_meetingentity_attenders { get; set; } = new List<meeting_meetingentity_attender>();

    public virtual ICollection<meeting_meetingpayloadbase> meeting_meetingpayloadbases { get; set; } = new List<meeting_meetingpayloadbase>();

    public virtual ICollection<meeting_meetingtransaction> meeting_meetingtransactions { get; set; } = new List<meeting_meetingtransaction>();

    public virtual ICollection<mobile_announcement> mobile_announcementinit_senders { get; set; } = new List<mobile_announcement>();

    public virtual ICollection<mobile_announcement> mobile_announcementreceivers { get; set; } = new List<mobile_announcement>();

    public virtual ICollection<mobile_appnotification> mobile_appnotificationinit_senders { get; set; } = new List<mobile_appnotification>();

    public virtual ICollection<mobile_appnotification> mobile_appnotificationreceivers { get; set; } = new List<mobile_appnotification>();

    public virtual ICollection<mobile_gpsforemployee> mobile_gpsforemployees { get; set; } = new List<mobile_gpsforemployee>();

    public virtual ICollection<mobile_mobileapirequestlog> mobile_mobileapirequestlogs { get; set; } = new List<mobile_mobileapirequestlog>();

    public virtual ICollection<payroll_emploan> payroll_emploans { get; set; } = new List<payroll_emploan>();

    public virtual payroll_emppayrollprofile? payroll_emppayrollprofile { get; set; }

    public virtual ICollection<payroll_extradeduction> payroll_extradeductions { get; set; } = new List<payroll_extradeduction>();

    public virtual ICollection<payroll_extraincrease> payroll_extraincreases { get; set; } = new List<payroll_extraincrease>();

    public virtual ICollection<payroll_payrollpayload> payroll_payrollpayloads { get; set; } = new List<payroll_payrollpayload>();

    public virtual ICollection<payroll_reimbursement> payroll_reimbursements { get; set; } = new List<payroll_reimbursement>();

    public virtual ICollection<payroll_salaryadvance> payroll_salaryadvances { get; set; } = new List<payroll_salaryadvance>();

    public virtual ICollection<payroll_salarystructure> payroll_salarystructures { get; set; } = new List<payroll_salarystructure>();

    public virtual ICollection<personnel_assignareaemployee> personnel_assignareaemployees { get; set; } = new List<personnel_assignareaemployee>();

    public virtual ICollection<personnel_department> personnel_departments { get; set; } = new List<personnel_department>();

    public virtual ICollection<personnel_employee_area> personnel_employee_areas { get; set; } = new List<personnel_employee_area>();

    public virtual ICollection<personnel_employee_flow_role> personnel_employee_flow_roles { get; set; } = new List<personnel_employee_flow_role>();

    public virtual ICollection<personnel_employeecalendar> personnel_employeecalendars { get; set; } = new List<personnel_employeecalendar>();

    public virtual ICollection<personnel_employeecertification> personnel_employeecertifications { get; set; } = new List<personnel_employeecertification>();

    public virtual personnel_employeeextrainfo? personnel_employeeextrainfo { get; set; }

    public virtual personnel_employeeprofile? personnel_employeeprofile { get; set; }

    public virtual personnel_employment? personnel_employment { get; set; }

    public virtual personnel_resign? personnel_resign { get; set; }

    public virtual personnel_position? position { get; set; }

    public virtual staff_stafftoken? staff_stafftoken { get; set; }

    public virtual personnel_employee? superior { get; set; }

    public virtual ICollection<visitor_visitor> visitor_visitors { get; set; } = new List<visitor_visitor>();

    public virtual ICollection<workflow_nodeinstance> workflow_nodeinstances { get; set; } = new List<workflow_nodeinstance>();

    public virtual ICollection<workflow_workflowengine_employee> workflow_workflowengine_employees { get; set; } = new List<workflow_workflowengine_employee>();

    public virtual ICollection<workflow_workflowinstance> workflow_workflowinstances { get; set; } = new List<workflow_workflowinstance>();
}
