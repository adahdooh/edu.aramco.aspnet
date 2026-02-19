using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace edu.aramco.aspnet.scaffold.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<_zz> _zzs { get; set; }

    public virtual DbSet<acc_acccombination> acc_acccombinations { get; set; }

    public virtual DbSet<acc_accgroup> acc_accgroups { get; set; }

    public virtual DbSet<acc_accholiday> acc_accholidays { get; set; }

    public virtual DbSet<acc_accprivilege> acc_accprivileges { get; set; }

    public virtual DbSet<acc_accterminal> acc_accterminals { get; set; }

    public virtual DbSet<acc_acctimezone> acc_acctimezones { get; set; }

    public virtual DbSet<accounts_adminbiodatum> accounts_adminbiodata { get; set; }

    public virtual DbSet<accounts_usernotification> accounts_usernotifications { get; set; }

    public virtual DbSet<att_attcalclog> att_attcalclogs { get; set; }

    public virtual DbSet<att_attcode> att_attcodes { get; set; }

    public virtual DbSet<att_attemployee> att_attemployees { get; set; }

    public virtual DbSet<att_attgroup> att_attgroups { get; set; }

    public virtual DbSet<att_attpolicy> att_attpolicies { get; set; }

    public virtual DbSet<att_attreportsetting> att_attreportsettings { get; set; }

    public virtual DbSet<att_attrule> att_attrules { get; set; }

    public virtual DbSet<att_attschedule> att_attschedules { get; set; }

    public virtual DbSet<att_attshift> att_attshifts { get; set; }

    public virtual DbSet<att_breaktime> att_breaktimes { get; set; }

    public virtual DbSet<att_calculatelastdate> att_calculatelastdates { get; set; }

    public virtual DbSet<att_calculatetask> att_calculatetasks { get; set; }

    public virtual DbSet<att_changeschedule> att_changeschedules { get; set; }

    public virtual DbSet<att_departmentpolicy> att_departmentpolicies { get; set; }

    public virtual DbSet<att_departmentschedule> att_departmentschedules { get; set; }

    public virtual DbSet<att_deptattrule> att_deptattrules { get; set; }

    public virtual DbSet<att_grouppolicy> att_grouppolicies { get; set; }

    public virtual DbSet<att_groupschedule> att_groupschedules { get; set; }

    public virtual DbSet<att_holiday> att_holidays { get; set; }

    public virtual DbSet<att_leave> att_leaves { get; set; }

    public virtual DbSet<att_leavegroup> att_leavegroups { get; set; }

    public virtual DbSet<att_leavegroupdetail> att_leavegroupdetails { get; set; }

    public virtual DbSet<att_leaveyearbalance> att_leaveyearbalances { get; set; }

    public virtual DbSet<att_manuallog> att_manuallogs { get; set; }

    public virtual DbSet<att_overtime> att_overtimes { get; set; }

    public virtual DbSet<att_overtimepolicy> att_overtimepolicies { get; set; }

    public virtual DbSet<att_paycode> att_paycodes { get; set; }

    public virtual DbSet<att_payloadattcode> att_payloadattcodes { get; set; }

    public virtual DbSet<att_payloadbase> att_payloadbases { get; set; }

    public virtual DbSet<att_payloadbreak> att_payloadbreaks { get; set; }

    public virtual DbSet<att_payloadeffectpunch> att_payloadeffectpunches { get; set; }

    public virtual DbSet<att_payloadexception> att_payloadexceptions { get; set; }

    public virtual DbSet<att_payloadmulpunchset> att_payloadmulpunchsets { get; set; }

    public virtual DbSet<att_payloadovertime> att_payloadovertimes { get; set; }

    public virtual DbSet<att_payloadparing> att_payloadparings { get; set; }

    public virtual DbSet<att_payloadpaycode> att_payloadpaycodes { get; set; }

    public virtual DbSet<att_payloadpunch> att_payloadpunches { get; set; }

    public virtual DbSet<att_payloadtimecard> att_payloadtimecards { get; set; }

    public virtual DbSet<att_reportparam> att_reportparams { get; set; }

    public virtual DbSet<att_reporttemplate> att_reporttemplates { get; set; }

    public virtual DbSet<att_shiftdetail> att_shiftdetails { get; set; }

    public virtual DbSet<att_temporaryschedule> att_temporaryschedules { get; set; }

    public virtual DbSet<att_tempschedule> att_tempschedules { get; set; }

    public virtual DbSet<att_timeinterval> att_timeintervals { get; set; }

    public virtual DbSet<att_timeinterval_break_time> att_timeinterval_break_times { get; set; }

    public virtual DbSet<att_training> att_trainings { get; set; }

    public virtual DbSet<att_webpunch> att_webpunches { get; set; }

    public virtual DbSet<attparam> attparams { get; set; }

    public virtual DbSet<audit> audits { get; set; }

    public virtual DbSet<auth_group> auth_groups { get; set; }

    public virtual DbSet<auth_group_permission> auth_group_permissions { get; set; }

    public virtual DbSet<auth_permission> auth_permissions { get; set; }

    public virtual DbSet<auth_user> auth_users { get; set; }

    public virtual DbSet<auth_user_auth_area> auth_user_auth_areas { get; set; }

    public virtual DbSet<auth_user_auth_dept> auth_user_auth_depts { get; set; }

    public virtual DbSet<auth_user_group> auth_user_groups { get; set; }

    public virtual DbSet<auth_user_profile> auth_user_profiles { get; set; }

    public virtual DbSet<auth_user_user_permission> auth_user_user_permissions { get; set; }

    public virtual DbSet<authtoken_token> authtoken_tokens { get; set; }

    public virtual DbSet<base_adminlog> base_adminlogs { get; set; }

    public virtual DbSet<base_attparamdept> base_attparamdepts { get; set; }

    public virtual DbSet<base_autoattexporttask> base_autoattexporttasks { get; set; }

    public virtual DbSet<base_autoexporttask> base_autoexporttasks { get; set; }

    public virtual DbSet<base_autoimporttask> base_autoimporttasks { get; set; }

    public virtual DbSet<base_bookmark> base_bookmarks { get; set; }

    public virtual DbSet<base_dbbackuplog> base_dbbackuplogs { get; set; }

    public virtual DbSet<base_emailtemplate> base_emailtemplates { get; set; }

    public virtual DbSet<base_eventalertsetting> base_eventalertsettings { get; set; }

    public virtual DbSet<base_fixedexporttask> base_fixedexporttasks { get; set; }

    public virtual DbSet<base_linenotifysetting> base_linenotifysettings { get; set; }

    public virtual DbSet<base_securitypolicy> base_securitypolicies { get; set; }

    public virtual DbSet<base_sendemail> base_sendemails { get; set; }

    public virtual DbSet<base_sftpsetting> base_sftpsettings { get; set; }

    public virtual DbSet<base_sysparam> base_sysparams { get; set; }

    public virtual DbSet<base_sysparamdept> base_sysparamdepts { get; set; }

    public virtual DbSet<base_systemlog> base_systemlogs { get; set; }

    public virtual DbSet<base_systemsetting> base_systemsettings { get; set; }

    public virtual DbSet<base_whatsapplog> base_whatsapplogs { get; set; }

    public virtual DbSet<django_admin_log> django_admin_logs { get; set; }

    public virtual DbSet<django_celery_beat_clockedschedule> django_celery_beat_clockedschedules { get; set; }

    public virtual DbSet<django_celery_beat_crontabschedule> django_celery_beat_crontabschedules { get; set; }

    public virtual DbSet<django_celery_beat_intervalschedule> django_celery_beat_intervalschedules { get; set; }

    public virtual DbSet<django_celery_beat_periodictask> django_celery_beat_periodictasks { get; set; }

    public virtual DbSet<django_celery_beat_periodictask1> django_celery_beat_periodictasks1 { get; set; }

    public virtual DbSet<django_celery_beat_solarschedule> django_celery_beat_solarschedules { get; set; }

    public virtual DbSet<django_content_type> django_content_types { get; set; }

    public virtual DbSet<django_migration> django_migrations { get; set; }

    public virtual DbSet<django_session> django_sessions { get; set; }

    public virtual DbSet<ep_epsetup> ep_epsetups { get; set; }

    public virtual DbSet<ep_eptransaction> ep_eptransactions { get; set; }

    public virtual DbSet<guardian_groupobjectpermission> guardian_groupobjectpermissions { get; set; }

    public virtual DbSet<guardian_userobjectpermission> guardian_userobjectpermissions { get; set; }

    public virtual DbSet<iclock_biodatum> iclock_biodata { get; set; }

    public virtual DbSet<iclock_biophoto> iclock_biophotos { get; set; }

    public virtual DbSet<iclock_devicemoduleconfig> iclock_devicemoduleconfigs { get; set; }

    public virtual DbSet<iclock_errorcommandlog> iclock_errorcommandlogs { get; set; }

    public virtual DbSet<iclock_privatemessage> iclock_privatemessages { get; set; }

    public virtual DbSet<iclock_publicmessage> iclock_publicmessages { get; set; }

    public virtual DbSet<iclock_shortmessage> iclock_shortmessages { get; set; }

    public virtual DbSet<iclock_terminal> iclock_terminals { get; set; }

    public virtual DbSet<iclock_terminalcommand> iclock_terminalcommands { get; set; }

    public virtual DbSet<iclock_terminalcommandlog> iclock_terminalcommandlogs { get; set; }

    public virtual DbSet<iclock_terminalemployee> iclock_terminalemployees { get; set; }

    public virtual DbSet<iclock_terminallog> iclock_terminallogs { get; set; }

    public virtual DbSet<iclock_terminalparameter> iclock_terminalparameters { get; set; }

    public virtual DbSet<iclock_terminaluploadlog> iclock_terminaluploadlogs { get; set; }

    public virtual DbSet<iclock_terminalworkcode> iclock_terminalworkcodes { get; set; }

    public virtual DbSet<iclock_transaction> iclock_transactions { get; set; }

    public virtual DbSet<iclock_transactionproofcmd> iclock_transactionproofcmds { get; set; }

    public virtual DbSet<meeting_meetingentity> meeting_meetingentities { get; set; }

    public virtual DbSet<meeting_meetingentity_attender> meeting_meetingentity_attenders { get; set; }

    public virtual DbSet<meeting_meetingmanuallog> meeting_meetingmanuallogs { get; set; }

    public virtual DbSet<meeting_meetingpayloadbase> meeting_meetingpayloadbases { get; set; }

    public virtual DbSet<meeting_meetingroom> meeting_meetingrooms { get; set; }

    public virtual DbSet<meeting_meetingroomdevice> meeting_meetingroomdevices { get; set; }

    public virtual DbSet<meeting_meetingtransaction> meeting_meetingtransactions { get; set; }

    public virtual DbSet<mobile_announcement> mobile_announcements { get; set; }

    public virtual DbSet<mobile_appactionlog> mobile_appactionlogs { get; set; }

    public virtual DbSet<mobile_applist> mobile_applists { get; set; }

    public virtual DbSet<mobile_appnotification> mobile_appnotifications { get; set; }

    public virtual DbSet<mobile_gpsfordepartment> mobile_gpsfordepartments { get; set; }

    public virtual DbSet<mobile_gpsfordepartment_location> mobile_gpsfordepartment_locations { get; set; }

    public virtual DbSet<mobile_gpsforemployee> mobile_gpsforemployees { get; set; }

    public virtual DbSet<mobile_gpsforemployee_location> mobile_gpsforemployee_locations { get; set; }

    public virtual DbSet<mobile_gpslocation> mobile_gpslocations { get; set; }

    public virtual DbSet<mobile_mobileapirequestlog> mobile_mobileapirequestlogs { get; set; }

    public virtual DbSet<payroll_deductionformula> payroll_deductionformulas { get; set; }

    public virtual DbSet<payroll_emploan> payroll_emploans { get; set; }

    public virtual DbSet<payroll_emppayrollprofile> payroll_emppayrollprofiles { get; set; }

    public virtual DbSet<payroll_exceptionformula> payroll_exceptionformulas { get; set; }

    public virtual DbSet<payroll_extradeduction> payroll_extradeductions { get; set; }

    public virtual DbSet<payroll_extraincrease> payroll_extraincreases { get; set; }

    public virtual DbSet<payroll_increasementformula> payroll_increasementformulas { get; set; }

    public virtual DbSet<payroll_leaveformula> payroll_leaveformulas { get; set; }

    public virtual DbSet<payroll_overtimeformula> payroll_overtimeformulas { get; set; }

    public virtual DbSet<payroll_payrollpayload> payroll_payrollpayloads { get; set; }

    public virtual DbSet<payroll_payrollpayloadpaycode> payroll_payrollpayloadpaycodes { get; set; }

    public virtual DbSet<payroll_reimbursement> payroll_reimbursements { get; set; }

    public virtual DbSet<payroll_salaryadvance> payroll_salaryadvances { get; set; }

    public virtual DbSet<payroll_salarystructure> payroll_salarystructures { get; set; }

    public virtual DbSet<payroll_salarystructure_deductionformula> payroll_salarystructure_deductionformulas { get; set; }

    public virtual DbSet<payroll_salarystructure_exceptionformula> payroll_salarystructure_exceptionformulas { get; set; }

    public virtual DbSet<payroll_salarystructure_increasementformula> payroll_salarystructure_increasementformulas { get; set; }

    public virtual DbSet<payroll_salarystructure_leaveformula> payroll_salarystructure_leaveformulas { get; set; }

    public virtual DbSet<payroll_salarystructure_overtimeformula> payroll_salarystructure_overtimeformulas { get; set; }

    public virtual DbSet<personnel_area> personnel_areas { get; set; }

    public virtual DbSet<personnel_assignareaemployee> personnel_assignareaemployees { get; set; }

    public virtual DbSet<personnel_certification> personnel_certifications { get; set; }

    public virtual DbSet<personnel_company> personnel_companies { get; set; }

    public virtual DbSet<personnel_department> personnel_departments { get; set; }

    public virtual DbSet<personnel_employee> personnel_employees { get; set; }

    public virtual DbSet<personnel_employee_area> personnel_employee_areas { get; set; }

    public virtual DbSet<personnel_employee_flow_role> personnel_employee_flow_roles { get; set; }

    public virtual DbSet<personnel_employeecalendar> personnel_employeecalendars { get; set; }

    public virtual DbSet<personnel_employeecertification> personnel_employeecertifications { get; set; }

    public virtual DbSet<personnel_employeecustomattribute> personnel_employeecustomattributes { get; set; }

    public virtual DbSet<personnel_employeeextrainfo> personnel_employeeextrainfos { get; set; }

    public virtual DbSet<personnel_employeeprofile> personnel_employeeprofiles { get; set; }

    public virtual DbSet<personnel_employment> personnel_employments { get; set; }

    public virtual DbSet<personnel_position> personnel_positions { get; set; }

    public virtual DbSet<personnel_resign> personnel_resigns { get; set; }

    public virtual DbSet<rest_framework_tracking_apirequestlog> rest_framework_tracking_apirequestlogs { get; set; }

    public virtual DbSet<staff_stafftoken> staff_stafftokens { get; set; }

    public virtual DbSet<sync_area> sync_areas { get; set; }

    public virtual DbSet<sync_department> sync_departments { get; set; }

    public virtual DbSet<sync_employee> sync_employees { get; set; }

    public virtual DbSet<sync_job> sync_jobs { get; set; }

    public virtual DbSet<visitor_reason> visitor_reasons { get; set; }

    public virtual DbSet<visitor_reservation> visitor_reservations { get; set; }

    public virtual DbSet<visitor_visitor> visitor_visitors { get; set; }

    public virtual DbSet<visitor_visitor_acc_group> visitor_visitor_acc_groups { get; set; }

    public virtual DbSet<visitor_visitor_area> visitor_visitor_areas { get; set; }

    public virtual DbSet<visitor_visitorbiodatum> visitor_visitorbiodata { get; set; }

    public virtual DbSet<visitor_visitorbiophoto> visitor_visitorbiophotos { get; set; }

    public virtual DbSet<visitor_visitorconfig> visitor_visitorconfigs { get; set; }

    public virtual DbSet<visitor_visitorlog> visitor_visitorlogs { get; set; }

    public virtual DbSet<visitor_visitortransaction> visitor_visitortransactions { get; set; }

    public virtual DbSet<workflow_nodeinstance> workflow_nodeinstances { get; set; }

    public virtual DbSet<workflow_workflowengine> workflow_workflowengines { get; set; }

    public virtual DbSet<workflow_workflowengine_employee> workflow_workflowengine_employees { get; set; }

    public virtual DbSet<workflow_workflowinstance> workflow_workflowinstances { get; set; }

    public virtual DbSet<workflow_workflownode> workflow_workflownodes { get; set; }

    public virtual DbSet<workflow_workflownode_approver> workflow_workflownode_approvers { get; set; }

    public virtual DbSet<workflow_workflownode_notifier> workflow_workflownode_notifiers { get; set; }

    public virtual DbSet<workflow_workflowrole> workflow_workflowroles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=IT-ELDAHDOUHA\\SQLEXPRESS;Database=zkt;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<_zz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_zz");

            entity.Property(e => e.area_alias).HasMaxLength(30);
            entity.Property(e => e.company_code).HasMaxLength(50);
            entity.Property(e => e.crc).HasMaxLength(100);
            entity.Property(e => e.emp_code).HasMaxLength(20);
            entity.Property(e => e.gps_location).HasMaxLength(300);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.mobile).HasMaxLength(50);
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");
            entity.Property(e => e.reserved).HasMaxLength(100);
            entity.Property(e => e.sync_time).HasColumnType("datetime");
            entity.Property(e => e.temperature).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.terminal_alias).HasMaxLength(50);
            entity.Property(e => e.terminal_sn).HasMaxLength(50);
            entity.Property(e => e.upload_time).HasColumnType("datetime");
            entity.Property(e => e.work_code).HasMaxLength(20);
        });

        modelBuilder.Entity<acc_acccombination>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__acc_accc__3213E83F2B597383");

            entity.ToTable("acc_acccombination");

            entity.HasIndex(e => e.area_id, "acc_acccombination_area_id_0d22c34e");

            entity.HasIndex(e => new { e.area_id, e.combination_no }, "acc_acccombination_area_id_combination_no_619eb4f5_uniq").IsUnique();

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.combination_name).HasMaxLength(100);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.remark).HasMaxLength(999);
            entity.Property(e => e.update_time).HasColumnType("datetime");

            entity.HasOne(d => d.area).WithMany(p => p.acc_acccombinations)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_acccombination_area_id_0d22c34e_fk_personnel_area_id");
        });

        modelBuilder.Entity<acc_accgroup>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__acc_accg__3213E83F2296EC51");

            entity.HasIndex(e => e.area_id, "acc_accgroups_area_id_b83745c3");

            entity.HasIndex(e => new { e.area_id, e.group_no }, "acc_accgroups_area_id_group_no_5130a89c_uniq").IsUnique();

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.group_name).HasMaxLength(100);
            entity.Property(e => e.update_time).HasColumnType("datetime");

            entity.HasOne(d => d.area).WithMany(p => p.acc_accgroups)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accgroups_area_id_b83745c3_fk_personnel_area_id");
        });

        modelBuilder.Entity<acc_accholiday>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__acc_acch__3213E83F2EEEB971");

            entity.ToTable("acc_accholiday");

            entity.HasIndex(e => e.area_id, "acc_accholiday_area_id_d15c19da");

            entity.HasIndex(e => new { e.area_id, e.holiday_id }, "acc_accholiday_area_id_holiday_id_6630c2eb_uniq").IsUnique();

            entity.HasIndex(e => e.holiday_id, "acc_accholiday_holiday_id_a9efe924");

            entity.HasIndex(e => e.timezone_id, "acc_accholiday_timezone_id_450d2d1e");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.update_time).HasColumnType("datetime");

            entity.HasOne(d => d.area).WithMany(p => p.acc_accholidays)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accholiday_area_id_d15c19da_fk_personnel_area_id");

            entity.HasOne(d => d.holiday).WithMany(p => p.acc_accholidays)
                .HasForeignKey(d => d.holiday_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accholiday_holiday_id_a9efe924_fk_att_holiday_id");

            entity.HasOne(d => d.timezone).WithMany(p => p.acc_accholidays)
                .HasForeignKey(d => d.timezone_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accholiday_timezone_id_450d2d1e_fk_acc_acctimezone_id");
        });

        modelBuilder.Entity<acc_accprivilege>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__acc_accp__3213E83FA90F9B9D");

            entity.ToTable("acc_accprivilege");

            entity.HasIndex(e => e.area_id, "acc_accprivilege_area_id_2123ff6f");

            entity.HasIndex(e => new { e.area_id, e.employee_id, e.group_id }, "acc_accprivilege_area_id_employee_id_group_id_f3b297d8_uniq").IsUnique();

            entity.HasIndex(e => e.employee_id, "acc_accprivilege_employee_id_5fc55f95");

            entity.HasIndex(e => e.group_id, "acc_accprivilege_group_id_c5ed7003");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.update_time).HasColumnType("datetime");

            entity.HasOne(d => d.area).WithMany(p => p.acc_accprivileges)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accprivilege_area_id_2123ff6f_fk_personnel_area_id");

            entity.HasOne(d => d.employee).WithMany(p => p.acc_accprivileges)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accprivilege_employee_id_5fc55f95_fk_personnel_employee_id");

            entity.HasOne(d => d.group).WithMany(p => p.acc_accprivileges)
                .HasForeignKey(d => d.group_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accprivilege_group_id_c5ed7003_fk_acc_accgroups_id");
        });

        modelBuilder.Entity<acc_accterminal>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__acc_acct__3213E83FCBF8D5A3");

            entity.ToTable("acc_accterminal");

            entity.HasIndex(e => e.terminal_id, "acc_accterminal_terminal_id_fc92cce2");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.door_name).HasMaxLength(50);
            entity.Property(e => e.push_time).HasColumnType("datetime");

            entity.HasOne(d => d.terminal).WithMany(p => p.acc_accterminals)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_accterminal_terminal_id_fc92cce2_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<acc_acctimezone>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__acc_acct__3213E83FE6B6EBDF");

            entity.ToTable("acc_acctimezone");

            entity.HasIndex(e => e.area_id, "acc_acctimezone_area_id_e9ce7a7a");

            entity.HasIndex(e => new { e.area_id, e.timezone_no }, "acc_acctimezone_area_id_timezone_no_0cb8250f_uniq").IsUnique();

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.fri_end).HasColumnType("datetime");
            entity.Property(e => e.fri_start).HasColumnType("datetime");
            entity.Property(e => e.mon_end).HasColumnType("datetime");
            entity.Property(e => e.mon_start).HasColumnType("datetime");
            entity.Property(e => e.remark).HasMaxLength(999);
            entity.Property(e => e.sat_end).HasColumnType("datetime");
            entity.Property(e => e.sat_start).HasColumnType("datetime");
            entity.Property(e => e.sun_end).HasColumnType("datetime");
            entity.Property(e => e.sun_start).HasColumnType("datetime");
            entity.Property(e => e.thu_end).HasColumnType("datetime");
            entity.Property(e => e.thu_start).HasColumnType("datetime");
            entity.Property(e => e.timezone_name).HasMaxLength(100);
            entity.Property(e => e.tue_end).HasColumnType("datetime");
            entity.Property(e => e.tue_start).HasColumnType("datetime");
            entity.Property(e => e.update_time).HasColumnType("datetime");
            entity.Property(e => e.wed_end).HasColumnType("datetime");
            entity.Property(e => e.wed_start).HasColumnType("datetime");

            entity.HasOne(d => d.area).WithMany(p => p.acc_acctimezones)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("acc_acctimezone_area_id_e9ce7a7a_fk_personnel_area_id");
        });

        modelBuilder.Entity<accounts_adminbiodatum>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__accounts__3213E83F4A3A92AA");

            entity.HasIndex(e => e.admin_id, "accounts_adminbiodata_admin_id_1e6d2d45");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.major_ver).HasMaxLength(30);
            entity.Property(e => e.minor_ver).HasMaxLength(30);

            entity.HasOne(d => d.admin).WithMany(p => p.accounts_adminbiodata)
                .HasForeignKey(d => d.admin_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounts_adminbiodata_admin_id_1e6d2d45_fk_auth_user_id");
        });

        modelBuilder.Entity<accounts_usernotification>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__accounts__3213E83FE3FC8FFC");

            entity.ToTable("accounts_usernotification");

            entity.HasIndex(e => e.user_id, "accounts_usernotification_user_id_b86755b3");

            entity.Property(e => e._event).HasColumnName("event");
            entity.Property(e => e.read_time).HasColumnType("datetime");
            entity.Property(e => e.send_time).HasColumnType("datetime");

            entity.HasOne(d => d.user).WithMany(p => p.accounts_usernotifications)
                .HasForeignKey(d => d.user_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounts_usernotification_user_id_b86755b3_fk_auth_user_id");
        });

        modelBuilder.Entity<att_attcalclog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_attc__3213E83FABB47B7C");

            entity.ToTable("att_attcalclog");

            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");
            entity.Property(e => e.update_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<att_attcode>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_attc__3213E83F74E85A23");

            entity.ToTable("att_attcode");

            entity.HasIndex(e => e.code, "UQ__att_attc__357D4CF908B7FF93").IsUnique();

            entity.HasIndex(e => e.alias, "UQ__att_attc__8C585C04E7B32BF3").IsUnique();

            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.code).HasMaxLength(20);
            entity.Property(e => e.color_setting).HasMaxLength(30);
            entity.Property(e => e.min_val).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.symbol).HasMaxLength(20);
        });

        modelBuilder.Entity<att_attemployee>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_atte__3213E83F84675660");

            entity.ToTable("att_attemployee");

            entity.HasIndex(e => e.emp_id, "UQ__att_atte__1299A860D6C9D2DE").IsUnique();

            entity.HasIndex(e => e.group_id, "att_attemployee_group_id_18d3954d");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.ip_address).HasMaxLength(39);

            entity.HasOne(d => d.emp).WithOne(p => p.att_attemployee)
                .HasForeignKey<att_attemployee>(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_attemployee_emp_id_52457e3c_fk_personnel_employee_id");

            entity.HasOne(d => d.group).WithMany(p => p.att_attemployees)
                .HasForeignKey(d => d.group_id)
                .HasConstraintName("att_attemployee_group_id_18d3954d_fk_att_attgroup_id");
        });

        modelBuilder.Entity<att_attgroup>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_attg__3213E83F66C52FC1");

            entity.ToTable("att_attgroup");

            entity.HasIndex(e => e.code, "UQ__att_attg__357D4CF9C95C4E5F").IsUnique();

            entity.HasIndex(e => e.name, "UQ__att_attg__72E12F1BB24AE63C").IsUnique();

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.code).HasMaxLength(50);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.name).HasMaxLength(100);
        });

        modelBuilder.Entity<att_attpolicy>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_attp__3213E83F7A8C2DC2");

            entity.ToTable("att_attpolicy");

            entity.HasIndex(e => e.ot_pay_code_id, "att_attpolicy_ot_pay_code_id_b189b952");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.daily_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.day_change).HasColumnType("datetime");
            entity.Property(e => e.email_send_time).HasColumnType("datetime");
            entity.Property(e => e.holiday_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.max_hrs).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.weekend1_color_setting).HasMaxLength(30);
            entity.Property(e => e.weekend2_color_setting).HasMaxLength(30);
            entity.Property(e => e.weekend_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.weekly_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.ot_pay_code).WithMany(p => p.att_attpolicies)
                .HasForeignKey(d => d.ot_pay_code_id)
                .HasConstraintName("att_attpolicy_ot_pay_code_id_b189b952_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_attreportsetting>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_attr__3213E83FF37C1E80");

            entity.ToTable("att_attreportsetting");

            entity.Property(e => e.calculate_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<att_attrule>(entity =>
        {
            entity.HasKey(e => e.param_name).HasName("PK__att_attr__71F4BD70FFA2CAF0");

            entity.ToTable("att_attrule");

            entity.Property(e => e.param_name).HasMaxLength(20);
        });

        modelBuilder.Entity<att_attschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_atts__3213E83FB3C4DDC3");

            entity.ToTable("att_attschedule");

            entity.HasIndex(e => e.employee_id, "att_attschedule_employee_id_caa61686");

            entity.HasIndex(e => e.shift_id, "att_attschedule_shift_id_13d2db9a");

            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.att_attschedules)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_attschedule_employee_id_caa61686_fk_personnel_employee_id");

            entity.HasOne(d => d.shift).WithMany(p => p.att_attschedules)
                .HasForeignKey(d => d.shift_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_attschedule_shift_id_13d2db9a_fk_att_attshift_id");
        });

        modelBuilder.Entity<att_attshift>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_atts__3213E83F8F37AED3");

            entity.ToTable("att_attshift");

            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<att_breaktime>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_brea__3213E83F2E0F8FF6");

            entity.ToTable("att_breaktime");

            entity.HasIndex(e => e.alias, "att_breaktime_alias_6212d9cf_uniq").IsUnique();

            entity.HasIndex(e => e.loss_code_id, "att_breaktime_loss_code_id_2ffb5432");

            entity.HasIndex(e => e.profit_code_id, "att_breaktime_profit_code_id_63cdbbcc");

            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.period_start).HasColumnType("datetime");

            entity.HasOne(d => d.loss_code).WithMany(p => p.att_breaktimeloss_codes)
                .HasForeignKey(d => d.loss_code_id)
                .HasConstraintName("att_breaktime_loss_code_id_2ffb5432_fk_att_paycode_id");

            entity.HasOne(d => d.profit_code).WithMany(p => p.att_breaktimeprofit_codes)
                .HasForeignKey(d => d.profit_code_id)
                .HasConstraintName("att_breaktime_profit_code_id_63cdbbcc_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_calculatelastdate>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_calc__3213E83FC12B6AB0");

            entity.ToTable("att_calculatelastdate");

            entity.HasIndex(e => e.last_date, "att_calculatelastdate_last_date_1441abdc");

            entity.Property(e => e.last_date).HasColumnType("datetime");
        });

        modelBuilder.Entity<att_calculatetask>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_calc__3213E83FE5D6D6FF");

            entity.ToTable("att_calculatetask");

            entity.HasIndex(e => e.end_date, "att_calculatetask_end_date_75d1d6d2");

            entity.HasIndex(e => e.start_date, "att_calculatetask_start_date_7bbaa889");

            entity.Property(e => e._event)
                .HasMaxLength(128)
                .HasColumnName("event");
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.execute_time).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");
        });

        modelBuilder.Entity<att_changeschedule>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__att_chan__2F050E151F71FD15");

            entity.ToTable("att_changeschedule");

            entity.HasIndex(e => e.timeinterval_id, "att_changeschedule_timeinterval_id_d41ac077");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_reason).HasMaxLength(200);
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.attachment).HasMaxLength(100);
            entity.Property(e => e.previous_timeinterval).HasMaxLength(100);

            entity.HasOne(d => d.timeinterval).WithMany(p => p.att_changeschedules)
                .HasForeignKey(d => d.timeinterval_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_changeschedule_timeinterval_id_d41ac077_fk_att_timeinterval_id");

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.att_changeschedule)
                .HasForeignKey<att_changeschedule>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_changeschedule_workflowinstance_ptr_id_cee602bb_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<att_departmentpolicy>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_depa__3213E83F62630CFD");

            entity.ToTable("att_departmentpolicy");

            entity.HasIndex(e => e.department_id, "att_departmentpolicy_department_id_77059a9d");

            entity.HasIndex(e => e.ot_pay_code_id, "att_departmentpolicy_ot_pay_code_id_390411dd");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.daily_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.day_change).HasColumnType("datetime");
            entity.Property(e => e.email_send_time).HasColumnType("datetime");
            entity.Property(e => e.holiday_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.max_hrs).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.weekend1_color_setting).HasMaxLength(30);
            entity.Property(e => e.weekend2_color_setting).HasMaxLength(30);
            entity.Property(e => e.weekend_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.weekly_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.department).WithMany(p => p.att_departmentpolicies)
                .HasForeignKey(d => d.department_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_departmentpolicy_department_id_77059a9d_fk_personnel_department_id");

            entity.HasOne(d => d.ot_pay_code).WithMany(p => p.att_departmentpolicies)
                .HasForeignKey(d => d.ot_pay_code_id)
                .HasConstraintName("att_departmentpolicy_ot_pay_code_id_390411dd_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_departmentschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_depa__3213E83F2C759DFC");

            entity.ToTable("att_departmentschedule");

            entity.HasIndex(e => e.department_id, "att_departmentschedule_department_id_c68fca3d");

            entity.HasIndex(e => e.shift_id, "att_departmentschedule_shift_id_c37d5ade");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");

            entity.HasOne(d => d.department).WithMany(p => p.att_departmentschedules)
                .HasForeignKey(d => d.department_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_departmentschedule_department_id_c68fca3d_fk_personnel_department_id");

            entity.HasOne(d => d.shift).WithMany(p => p.att_departmentschedules)
                .HasForeignKey(d => d.shift_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_departmentschedule_shift_id_c37d5ade_fk_att_attshift_id");
        });

        modelBuilder.Entity<att_deptattrule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_dept__3213E83F20A5E386");

            entity.ToTable("att_deptattrule");

            entity.HasIndex(e => e.department_id, "att_deptattrule_department_id_f333c8f0");

            entity.Property(e => e.alias).HasMaxLength(50);

            entity.HasOne(d => d.department).WithMany(p => p.att_deptattrules)
                .HasForeignKey(d => d.department_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_deptattrule_department_id_f333c8f0_fk_personnel_department_id");
        });

        modelBuilder.Entity<att_grouppolicy>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_grou__3213E83FF6EECBC1");

            entity.ToTable("att_grouppolicy");

            entity.HasIndex(e => e.group_id, "att_grouppolicy_group_id_b2e4dfe8");

            entity.HasIndex(e => e.ot_pay_code_id, "att_grouppolicy_ot_pay_code_id_1ec83080");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.daily_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.day_change).HasColumnType("datetime");
            entity.Property(e => e.email_send_time).HasColumnType("datetime");
            entity.Property(e => e.holiday_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.max_hrs).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.weekend1_color_setting).HasMaxLength(30);
            entity.Property(e => e.weekend2_color_setting).HasMaxLength(30);
            entity.Property(e => e.weekend_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.weekly_ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.group).WithMany(p => p.att_grouppolicies)
                .HasForeignKey(d => d.group_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_grouppolicy_group_id_b2e4dfe8_fk_att_attgroup_id");

            entity.HasOne(d => d.ot_pay_code).WithMany(p => p.att_grouppolicies)
                .HasForeignKey(d => d.ot_pay_code_id)
                .HasConstraintName("att_grouppolicy_ot_pay_code_id_1ec83080_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_groupschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_grou__3213E83F0B6F8244");

            entity.ToTable("att_groupschedule");

            entity.HasIndex(e => e.group_id, "att_groupschedule_group_id_c341493f");

            entity.HasIndex(e => e.shift_id, "att_groupschedule_shift_id_287e7fc0");

            entity.HasIndex(e => e.start_date, "att_groupschedule_start_date_638b6d85");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");

            entity.HasOne(d => d.group).WithMany(p => p.att_groupschedules)
                .HasForeignKey(d => d.group_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_groupschedule_group_id_c341493f_fk_att_attgroup_id");

            entity.HasOne(d => d.shift).WithMany(p => p.att_groupschedules)
                .HasForeignKey(d => d.shift_id)
                .HasConstraintName("att_groupschedule_shift_id_287e7fc0_fk_att_attshift_id");
        });

        modelBuilder.Entity<att_holiday>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_holi__3213E83F1749A9B4");

            entity.ToTable("att_holiday");

            entity.HasIndex(e => e.att_group_id, "att_holiday_att_group_id_9ddf13ba");

            entity.HasIndex(e => e.department_id, "att_holiday_department_id_fbbbd185");

            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.color_setting).HasMaxLength(30);
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.start_date).HasColumnType("datetime");

            entity.HasOne(d => d.att_group).WithMany(p => p.att_holidays)
                .HasForeignKey(d => d.att_group_id)
                .HasConstraintName("att_holiday_att_group_id_9ddf13ba_fk_att_attgroup_id");

            entity.HasOne(d => d.department).WithMany(p => p.att_holidays)
                .HasForeignKey(d => d.department_id)
                .HasConstraintName("att_holiday_department_id_fbbbd185_fk_personnel_department_id");
        });

        modelBuilder.Entity<att_leave>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__att_leav__2F050E1522FFAC5E");

            entity.ToTable("att_leave");

            entity.HasIndex(e => e.pay_code_id, "att_leave_pay_code_id_2fadf493");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.attachment).HasMaxLength(100);
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.start_time).HasColumnType("datetime");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_leaves)
                .HasForeignKey(d => d.pay_code_id)
                .HasConstraintName("att_leave_pay_code_id_2fadf493_fk_att_paycode_id");

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.att_leave)
                .HasForeignKey<att_leave>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_leave_workflowinstance_ptr_id_39aaa9d9_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<att_leavegroup>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_leav__3213E83FA3C37CC4");

            entity.ToTable("att_leavegroup");

            entity.HasIndex(e => e.code, "UQ__att_leav__357D4CF9FB952B1D").IsUnique();

            entity.HasIndex(e => e.name, "UQ__att_leav__72E12F1BD8793500").IsUnique();

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.code).HasMaxLength(50);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.name).HasMaxLength(100);
        });

        modelBuilder.Entity<att_leavegroupdetail>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_leav__3213E83F37F3288D");

            entity.ToTable("att_leavegroupdetail");

            entity.HasIndex(e => e.leave_group_id, "att_leavegroupdetail_leave_group_id_28f69ada");

            entity.HasIndex(e => e.pay_code_id, "att_leavegroupdetail_pay_code_id_5013b373");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.entitlement_detail).HasMaxLength(999);
            entity.Property(e => e.start_day).HasMaxLength(5);

            entity.HasOne(d => d.leave_group).WithMany(p => p.att_leavegroupdetails)
                .HasForeignKey(d => d.leave_group_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_leavegroupdetail_leave_group_id_28f69ada_fk_att_leavegroup_id");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_leavegroupdetails)
                .HasForeignKey(d => d.pay_code_id)
                .HasConstraintName("att_leavegroupdetail_pay_code_id_5013b373_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_leaveyearbalance>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_leav__3213E83F92537FA9");

            entity.ToTable("att_leaveyearbalance");

            entity.HasIndex(e => e.employee_id, "att_leaveyearbalance_employee_id_14febdb3");

            entity.HasIndex(e => new { e.employee_id, e.year, e.pay_code_id }, "att_leaveyearbalance_employee_id_year_pay_code_id_2ec71517_uniq").IsUnique();

            entity.HasIndex(e => e.pay_code_id, "att_leaveyearbalance_pay_code_id_82632aca");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);

            entity.HasOne(d => d.employee).WithMany(p => p.att_leaveyearbalances)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_leaveyearbalance_employee_id_14febdb3_fk_personnel_employee_id");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_leaveyearbalances)
                .HasForeignKey(d => d.pay_code_id)
                .HasConstraintName("att_leaveyearbalance_pay_code_id_82632aca_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_manuallog>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__att_manu__2F050E1527FA3B75");

            entity.ToTable("att_manuallog");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.attachment).HasMaxLength(100);
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");
            entity.Property(e => e.work_code).HasMaxLength(20);

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.att_manuallog)
                .HasForeignKey<att_manuallog>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_manuallog_workflowinstance_ptr_id_22a3fbd0_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<att_overtime>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__att_over__2F050E15B6B97BE0");

            entity.ToTable("att_overtime");

            entity.HasIndex(e => e.pay_code_id, "att_overtime_pay_code_id_05600ee0");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.attachment).HasMaxLength(100);
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.start_time).HasColumnType("datetime");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_overtimes)
                .HasForeignKey(d => d.pay_code_id)
                .HasConstraintName("att_overtime_pay_code_id_05600ee0_fk_att_paycode_id");

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.att_overtime)
                .HasForeignKey<att_overtime>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_overtime_workflowinstance_ptr_id_6bd6a6f4_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<att_overtimepolicy>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_over__3213E83FD3500700");

            entity.ToTable("att_overtimepolicy");

            entity.HasIndex(e => e.overnight_pay_code_id, "att_overtimepolicy_overnight_pay_code_id_274ce1b0");

            entity.HasIndex(e => e.pay_code_id, "att_overtimepolicy_pay_code_id_285b0a61");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.hrs_from).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.hrs_to).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.master)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.overnight_pay_code).WithMany(p => p.att_overtimepolicyovernight_pay_codes)
                .HasForeignKey(d => d.overnight_pay_code_id)
                .HasConstraintName("att_overtimepolicy_overnight_pay_code_id_274ce1b0_fk_att_paycode_id");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_overtimepolicypay_codes)
                .HasForeignKey(d => d.pay_code_id)
                .HasConstraintName("att_overtimepolicy_pay_code_id_285b0a61_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_paycode>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_payc__3213E83F316F6113");

            entity.ToTable("att_paycode");

            entity.HasIndex(e => e.code, "UQ__att_payc__357D4CF91081334D").IsUnique();

            entity.HasIndex(e => e.name, "UQ__att_payc__72E12F1B9F403A95").IsUnique();

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.code).HasMaxLength(20);
            entity.Property(e => e.color_setting).HasMaxLength(30);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.fixed_hours).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.min_val).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.name).HasMaxLength(50);
            entity.Property(e => e.symbol).HasMaxLength(20);
        });

        modelBuilder.Entity<att_payloadattcode>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_payl__3213E83F5372FF17");

            entity.ToTable("att_payloadattcode");

            entity.HasIndex(e => e.att_code_id, "att_payloadattcode_att_code_id_0d635efd");

            entity.HasIndex(e => e.att_date, "att_payloadattcode_att_date_19b2621e");

            entity.HasIndex(e => e.emp_id, "att_payloadattcode_emp_id_36569f54");

            entity.HasIndex(e => e.shift_id, "att_payloadattcode_shift_id_731faddf");

            entity.HasIndex(e => e.time_card_id, "att_payloadattcode_time_card_id_e8a37c7a");

            entity.Property(e => e.id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.att_code_alias).HasMaxLength(50);
            entity.Property(e => e.att_code_symbol).HasMaxLength(20);
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.hours).HasColumnType("numeric(6, 1)");
            entity.Property(e => e.minutes).HasColumnType("numeric(8, 1)");
            entity.Property(e => e.time_card_id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.workday).HasColumnType("numeric(4, 1)");

            entity.HasOne(d => d.att_code).WithMany(p => p.att_payloadattcodes)
                .HasForeignKey(d => d.att_code_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadattcode_att_code_id_0d635efd_fk_att_attcode_id");

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadattcodes)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadattcode_emp_id_36569f54_fk_personnel_employee_id");

            entity.HasOne(d => d.shift).WithMany(p => p.att_payloadattcodes)
                .HasForeignKey(d => d.shift_id)
                .HasConstraintName("att_payloadattcode_shift_id_731faddf_fk_att_attshift_id");
        });

        modelBuilder.Entity<att_payloadbase>(entity =>
        {
            entity.HasKey(e => e.uuid).HasName("PK__att_payl__7F427930ED449C40");

            entity.ToTable("att_payloadbase");

            entity.HasIndex(e => e.break_time_id, "UQ__att_payl__3C490B12E7CF450E").IsUnique();

            entity.HasIndex(e => e.overtime_id, "UQ__att_payl__B846E81054776BB4").IsUnique();

            entity.HasIndex(e => e.emp_id, "att_payloadbase_emp_id_2c0f6a7b");

            entity.HasIndex(e => e.timetable_id, "att_payloadbase_timetable_id_a389e3d8");

            entity.Property(e => e.uuid).HasMaxLength(36);
            entity.Property(e => e._short).HasColumnName("short");
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.break_time_id).HasMaxLength(36);
            entity.Property(e => e.check_in).HasColumnType("datetime");
            entity.Property(e => e.check_out).HasColumnType("datetime");
            entity.Property(e => e.clock_in).HasColumnType("datetime");
            entity.Property(e => e.clock_out).HasColumnType("datetime");
            entity.Property(e => e.exception).HasMaxLength(50);
            entity.Property(e => e.overtime_id).HasMaxLength(36);

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadbases)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadbase_emp_id_2c0f6a7b_fk_personnel_employee_id");

            entity.HasOne(d => d.timetable).WithMany(p => p.att_payloadbases)
                .HasForeignKey(d => d.timetable_id)
                .HasConstraintName("att_payloadbase_timetable_id_a389e3d8_fk_att_timeinterval_id");
        });

        modelBuilder.Entity<att_payloadbreak>(entity =>
        {
            entity.HasKey(e => e.uuid).HasName("PK__att_payl__7F427930EB361D45");

            entity.ToTable("att_payloadbreak");

            entity.Property(e => e.uuid).HasMaxLength(36);
            entity.Property(e => e.break_in).HasColumnType("datetime");
            entity.Property(e => e.break_out).HasColumnType("datetime");
        });

        modelBuilder.Entity<att_payloadeffectpunch>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_payl__3213E83F8FB11B2E");

            entity.ToTable("att_payloadeffectpunch");

            entity.HasIndex(e => e.att_date, "att_payloadeffectpunch_att_date_1e3de2d4");

            entity.HasIndex(e => e.emp_id, "att_payloadeffectpunch_emp_id_67e28e01");

            entity.HasIndex(e => e.time_card_id, "att_payloadeffectpunch_time_card_id_52f69aaf");

            entity.HasIndex(e => e.trans_id, "att_payloadeffectpunch_trans_id_94affbe6");

            entity.Property(e => e.id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.adjust_state).HasMaxLength(5);
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.punch_date).HasColumnType("datetime");
            entity.Property(e => e.punch_datetime).HasColumnType("datetime");
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");
            entity.Property(e => e.time_card_id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.work_code).HasMaxLength(20);

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadeffectpunches)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadeffectpunch_emp_id_67e28e01_fk_personnel_employee_id");

            entity.HasOne(d => d.trans).WithMany(p => p.att_payloadeffectpunches)
                .HasForeignKey(d => d.trans_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadeffectpunch_trans_id_94affbe6_fk_iclock_transaction_id");
        });

        modelBuilder.Entity<att_payloadexception>(entity =>
        {
            entity.HasKey(e => e.uuid).HasName("PK__att_payl__7F42793034429B44");

            entity.ToTable("att_payloadexception");

            entity.HasIndex(e => e.item_id, "att_payloadexception_item_id_a08bfe48");

            entity.HasIndex(e => e.skd_id, "att_payloadexception_skd_id_b2e9ecaa");

            entity.Property(e => e.uuid).HasMaxLength(36);
            entity.Property(e => e.description).HasMaxLength(50);
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.skd_id).HasMaxLength(36);
            entity.Property(e => e.start_time).HasColumnType("datetime");

            entity.HasOne(d => d.item).WithMany(p => p.att_payloadexceptions)
                .HasForeignKey(d => d.item_id)
                .HasConstraintName("att_payloadexception_item_id_a08bfe48_fk_att_leave_workflowinstance_ptr_id");
        });

        modelBuilder.Entity<att_payloadmulpunchset>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_payl__3213E83FB69B5AE4");

            entity.ToTable("att_payloadmulpunchset");

            entity.HasIndex(e => e.emp_id, "att_payloadmulpunchset_emp_id_f47610c8");

            entity.HasIndex(e => e.timetable_id, "att_payloadmulpunchset_timetable_id_9a439a09");

            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.clock_in).HasColumnType("datetime");
            entity.Property(e => e.clock_out).HasColumnType("datetime");

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadmulpunchsets)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadmulpunchset_emp_id_f47610c8_fk_personnel_employee_id");
        });

        modelBuilder.Entity<att_payloadovertime>(entity =>
        {
            entity.HasKey(e => e.uuid).HasName("PK__att_payl__7F4279307230B363");

            entity.ToTable("att_payloadovertime");

            entity.Property(e => e.uuid).HasMaxLength(36);
        });

        modelBuilder.Entity<att_payloadparing>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_payl__3213E83F05A89F69");

            entity.ToTable("att_payloadparing");

            entity.HasIndex(e => e.att_date, "att_payloadparing_att_date_5daaa45d");

            entity.HasIndex(e => e.emp_id, "att_payloadparing_emp_id_c5daac4f");

            entity.HasIndex(e => e.in_trans_id, "att_payloadparing_in_trans_id_50a8040e");

            entity.HasIndex(e => e.out_trans_id, "att_payloadparing_out_trans_id_8b2375b9");

            entity.HasIndex(e => e.pay_code_id, "att_payloadparing_pay_code_id_aa241cca");

            entity.HasIndex(e => e.time_card_id, "att_payloadparing_time_card_id_3adc3517");

            entity.Property(e => e.id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.clock_in).HasColumnType("datetime");
            entity.Property(e => e.clock_out).HasColumnType("datetime");
            entity.Property(e => e.in_date).HasColumnType("datetime");
            entity.Property(e => e.in_time).HasColumnType("datetime");
            entity.Property(e => e.out_date).HasColumnType("datetime");
            entity.Property(e => e.out_time).HasColumnType("datetime");
            entity.Property(e => e.time_card_id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.workday).HasColumnType("numeric(4, 1)");

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadparings)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadparing_emp_id_c5daac4f_fk_personnel_employee_id");

            entity.HasOne(d => d.in_trans).WithMany(p => p.att_payloadparingin_trans)
                .HasForeignKey(d => d.in_trans_id)
                .HasConstraintName("att_payloadparing_in_trans_id_50a8040e_fk_iclock_transaction_id");

            entity.HasOne(d => d.out_trans).WithMany(p => p.att_payloadparingout_trans)
                .HasForeignKey(d => d.out_trans_id)
                .HasConstraintName("att_payloadparing_out_trans_id_8b2375b9_fk_iclock_transaction_id");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_payloadparings)
                .HasForeignKey(d => d.pay_code_id)
                .HasConstraintName("att_payloadparing_pay_code_id_aa241cca_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_payloadpaycode>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_payl__3213E83FF65BF990");

            entity.ToTable("att_payloadpaycode");

            entity.HasIndex(e => e.att_date, "att_payloadpaycode_att_date_aa048d7b");

            entity.HasIndex(e => e.emp_id, "att_payloadpaycode_emp_id_78e75279");

            entity.HasIndex(e => e.pay_code_id, "att_payloadpaycode_pay_code_id_4a096cc7");

            entity.HasIndex(e => e.shift_id, "att_payloadpaycode_shift_id_79a0901e");

            entity.HasIndex(e => e.time_card_id, "att_payloadpaycode_time_card_id_1696b969");

            entity.Property(e => e.id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.hours).HasColumnType("numeric(6, 1)");
            entity.Property(e => e.minutes).HasColumnType("numeric(8, 1)");
            entity.Property(e => e.pay_code_alias).HasMaxLength(50);
            entity.Property(e => e.pay_code_symbol).HasMaxLength(20);
            entity.Property(e => e.time_card_id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.workday).HasColumnType("numeric(4, 1)");

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadpaycodes)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadpaycode_emp_id_78e75279_fk_personnel_employee_id");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_payloadpaycodes)
                .HasForeignKey(d => d.pay_code_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadpaycode_pay_code_id_4a096cc7_fk_att_paycode_id");

            entity.HasOne(d => d.shift).WithMany(p => p.att_payloadpaycodes)
                .HasForeignKey(d => d.shift_id)
                .HasConstraintName("att_payloadpaycode_shift_id_79a0901e_fk_att_attshift_id");
        });

        modelBuilder.Entity<att_payloadpunch>(entity =>
        {
            entity.HasKey(e => e.uuid).HasName("PK__att_payl__7F427930A90FC7A9");

            entity.ToTable("att_payloadpunch");

            entity.HasIndex(e => e.emp_id, "att_payloadpunch_emp_id_053da2f0");

            entity.HasIndex(e => e.orig_id, "att_payloadpunch_orig_id_16b26416");

            entity.HasIndex(e => e.skd_id, "att_payloadpunch_skd_id_17596d82");

            entity.Property(e => e.uuid).HasMaxLength(36);
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.correct_state).HasMaxLength(3);
            entity.Property(e => e.skd_id).HasMaxLength(36);

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadpunches)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadpunch_emp_id_053da2f0_fk_personnel_employee_id");

            entity.HasOne(d => d.orig).WithMany(p => p.att_payloadpunches)
                .HasForeignKey(d => d.orig_id)
                .HasConstraintName("att_payloadpunch_orig_id_16b26416_fk_iclock_transaction_id");
        });

        modelBuilder.Entity<att_payloadtimecard>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_payl__3213E83F2C05B8BD");

            entity.ToTable("att_payloadtimecard");

            entity.HasIndex(e => e.att_date, "att_payloadtimecard_att_date_48c1dc00");

            entity.HasIndex(e => e.emp_id, "att_payloadtimecard_emp_id_47caeab4");

            entity.HasIndex(e => new { e.emp_id, e.att_date, e.time_table_id }, "att_payloadtimecard_emp_id_att_date_time_table_id_9df16bc5_uniq").IsUnique();

            entity.HasIndex(e => e.in_trans_id, "att_payloadtimecard_in_trans_id_d0e9c411");

            entity.HasIndex(e => e.out_trans_id, "att_payloadtimecard_out_trans_id_aff7023d");

            entity.HasIndex(e => e.time_table_id, "att_payloadtimecard_time_table_id_6e0b0137");

            entity.Property(e => e.id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.break_in).HasColumnType("datetime");
            entity.Property(e => e.break_out).HasColumnType("datetime");
            entity.Property(e => e.check_in).HasColumnType("datetime");
            entity.Property(e => e.check_out).HasColumnType("datetime");
            entity.Property(e => e.clock_in).HasColumnType("datetime");
            entity.Property(e => e.clock_out).HasColumnType("datetime");
            entity.Property(e => e.time_table_alias).HasMaxLength(50);
            entity.Property(e => e.work_day).HasColumnType("numeric(4, 1)");

            entity.HasOne(d => d.emp).WithMany(p => p.att_payloadtimecards)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_payloadtimecard_emp_id_47caeab4_fk_personnel_employee_id");

            entity.HasOne(d => d.in_trans).WithMany(p => p.att_payloadtimecardin_trans)
                .HasForeignKey(d => d.in_trans_id)
                .HasConstraintName("att_payloadtimecard_in_trans_id_d0e9c411_fk_iclock_transaction_id");

            entity.HasOne(d => d.out_trans).WithMany(p => p.att_payloadtimecardout_trans)
                .HasForeignKey(d => d.out_trans_id)
                .HasConstraintName("att_payloadtimecard_out_trans_id_aff7023d_fk_iclock_transaction_id");

            entity.HasOne(d => d.time_table).WithMany(p => p.att_payloadtimecards)
                .HasForeignKey(d => d.time_table_id)
                .HasConstraintName("att_payloadtimecard_time_table_id_6e0b0137_fk_att_timeinterval_id");
        });

        modelBuilder.Entity<att_reportparam>(entity =>
        {
            entity.HasKey(e => e.param_name).HasName("PK__att_repo__71F4BD70ECDDCA9B");

            entity.ToTable("att_reportparam");

            entity.Property(e => e.param_name).HasMaxLength(20);
        });

        modelBuilder.Entity<att_reporttemplate>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_repo__3213E83F3F57B6DB");

            entity.ToTable("att_reporttemplate");

            entity.HasIndex(e => e.builder_id, "att_reporttemplate_builder_id_e1bb15c6");

            entity.HasIndex(e => e.employee_id, "att_reporttemplate_employee_id_4f80d866");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.language).HasMaxLength(10);
            entity.Property(e => e.report).HasMaxLength(50);
            entity.Property(e => e.template_name).HasMaxLength(50);

            entity.HasOne(d => d.builder).WithMany(p => p.att_reporttemplates)
                .HasForeignKey(d => d.builder_id)
                .HasConstraintName("att_reporttemplate_builder_id_e1bb15c6_fk_auth_user_id");

            entity.HasOne(d => d.employee).WithMany(p => p.att_reporttemplates)
                .HasForeignKey(d => d.employee_id)
                .HasConstraintName("att_reporttemplate_employee_id_4f80d866_fk_personnel_employee_id");
        });

        modelBuilder.Entity<att_shiftdetail>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_shif__3213E83FD63ECD18");

            entity.ToTable("att_shiftdetail");

            entity.HasIndex(e => e.shift_id, "att_shiftdetail_shift_id_7d694501");

            entity.HasIndex(e => e.time_interval_id, "att_shiftdetail_time_interval_id_777dde8f");

            entity.Property(e => e.in_time).HasColumnType("datetime");
            entity.Property(e => e.out_time).HasColumnType("datetime");

            entity.HasOne(d => d.shift).WithMany(p => p.att_shiftdetails)
                .HasForeignKey(d => d.shift_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_shiftdetail_shift_id_7d694501_fk_att_attshift_id");

            entity.HasOne(d => d.time_interval).WithMany(p => p.att_shiftdetails)
                .HasForeignKey(d => d.time_interval_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_shiftdetail_time_interval_id_777dde8f_fk_att_timeinterval_id");
        });

        modelBuilder.Entity<att_temporaryschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_temp__3213E83FFA4A35FE");

            entity.ToTable("att_temporaryschedule");

            entity.HasIndex(e => e.att_date, "att_temporaryschedule_att_date_8aed8916");

            entity.HasIndex(e => e.employee_id, "att_temporaryschedule_employee_id_2b2b94c2");

            entity.HasIndex(e => e.time_interval_id, "att_temporaryschedule_time_interval_id_2be60ee4");

            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);

            entity.HasOne(d => d.employee).WithMany(p => p.att_temporaryschedules)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_temporaryschedule_employee_id_2b2b94c2_fk_personnel_employee_id");
        });

        modelBuilder.Entity<att_tempschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_temp__3213E83FCCC163B8");

            entity.ToTable("att_tempschedule");

            entity.HasIndex(e => e.employee_id, "att_tempschedule_employee_id_b89c7e54");

            entity.HasIndex(e => e.time_interval_id, "att_tempschedule_time_interval_id_08dd8eb3");

            entity.Property(e => e.att_date).HasColumnType("datetime");
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.start_time).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.att_tempschedules)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_tempschedule_employee_id_b89c7e54_fk_personnel_employee_id");
        });

        modelBuilder.Entity<att_timeinterval>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_time__3213E83FBBF762AE");

            entity.ToTable("att_timeinterval");

            entity.HasIndex(e => e.alias, "UQ__att_time__8C585C0478C04259").IsUnique();

            entity.HasIndex(e => e.ot_pay_code_id, "att_timeinterval_ot_pay_code_id_17438af8");

            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.color_setting).HasMaxLength(30);
            entity.Property(e => e.day_change).HasColumnType("datetime");
            entity.Property(e => e.in_time).HasColumnType("datetime");
            entity.Property(e => e.ot_rule)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.ot_pay_code).WithMany(p => p.att_timeintervals)
                .HasForeignKey(d => d.ot_pay_code_id)
                .HasConstraintName("att_timeinterval_ot_pay_code_id_17438af8_fk_att_paycode_id");
        });

        modelBuilder.Entity<att_timeinterval_break_time>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__att_time__3213E83FFD6E8661");

            entity.ToTable("att_timeinterval_break_time");

            entity.HasIndex(e => e.breaktime_id, "att_timeinterval_break_time_breaktime_id_08462308");

            entity.HasIndex(e => e.timeinterval_id, "att_timeinterval_break_time_timeinterval_id_2287017e");

            entity.HasIndex(e => new { e.timeinterval_id, e.breaktime_id }, "att_timeinterval_break_time_timeinterval_id_breaktime_id_6e1bfb4e_uniq").IsUnique();

            entity.HasOne(d => d.breaktime).WithMany(p => p.att_timeinterval_break_times)
                .HasForeignKey(d => d.breaktime_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_timeinterval_break_time_breaktime_id_08462308_fk_att_breaktime_id");

            entity.HasOne(d => d.timeinterval).WithMany(p => p.att_timeinterval_break_times)
                .HasForeignKey(d => d.timeinterval_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_timeinterval_break_time_timeinterval_id_2287017e_fk_att_timeinterval_id");
        });

        modelBuilder.Entity<att_training>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__att_trai__2F050E153F34CE68");

            entity.ToTable("att_training");

            entity.HasIndex(e => e.pay_code_id, "att_training_pay_code_id_5790afdd");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.attachment).HasMaxLength(100);
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.start_time).HasColumnType("datetime");

            entity.HasOne(d => d.pay_code).WithMany(p => p.att_trainings)
                .HasForeignKey(d => d.pay_code_id)
                .HasConstraintName("att_training_pay_code_id_5790afdd_fk_att_paycode_id");

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.att_training)
                .HasForeignKey<att_training>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_training_workflowinstance_ptr_id_0aef1508_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<att_webpunch>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__att_webp__2F050E1549E27CA1");

            entity.ToTable("att_webpunch");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");
            entity.Property(e => e.work_code).HasMaxLength(20);

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.att_webpunch)
                .HasForeignKey<att_webpunch>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("att_webpunch_workflowinstance_ptr_id_c5f1c02e_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<attparam>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__attparam__3213E83F20E4F2B4");

            entity.ToTable("attparam");

            entity.HasIndex(e => new { e.paraname, e.paratype }, "attparam_paraname_paratype_6f176d25_uniq").IsUnique();

            entity.Property(e => e.paraname).HasMaxLength(30);
            entity.Property(e => e.paratype).HasMaxLength(10);
            entity.Property(e => e.paravalue).HasMaxLength(250);
        });

        modelBuilder.Entity<audit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__audit__3214EC07D2FCA30C");

            entity.ToTable("audit");

            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmpCode).HasMaxLength(100);
            entity.Property(e => e.EventType).HasMaxLength(50);
            entity.Property(e => e.OldValue).HasColumnType("datetime");
            entity.Property(e => e.PunchTime).HasColumnType("datetime");
            entity.Property(e => e.UpdatedByEmail).HasMaxLength(100);
        });

        modelBuilder.Entity<auth_group>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_gro__3213E83FB8A47FC2");

            entity.ToTable("auth_group");

            entity.HasIndex(e => e.name, "UQ__auth_gro__72E12F1BA40B0CC7").IsUnique();

            entity.Property(e => e.name).HasMaxLength(80);
        });

        modelBuilder.Entity<auth_group_permission>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_gro__3213E83FAE8C6E2E");

            entity.HasIndex(e => e.group_id, "auth_group_permissions_group_id_b120cbf9");

            entity.HasIndex(e => new { e.group_id, e.permission_id }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq").IsUnique();

            entity.HasIndex(e => e.permission_id, "auth_group_permissions_permission_id_84c5c92e");

            entity.HasOne(d => d.group).WithMany(p => p.auth_group_permissions)
                .HasForeignKey(d => d.group_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

            entity.HasOne(d => d.permission).WithMany(p => p.auth_group_permissions)
                .HasForeignKey(d => d.permission_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_permission_id_84c5c92e_fk_auth_permission_id");
        });

        modelBuilder.Entity<auth_permission>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_per__3213E83FD131D0C9");

            entity.ToTable("auth_permission");

            entity.HasIndex(e => e.content_type_id, "auth_permission_content_type_id_2f476e4b");

            entity.HasIndex(e => new { e.content_type_id, e.codename }, "auth_permission_content_type_id_codename_01ab375a_uniq").IsUnique();

            entity.Property(e => e.codename).HasMaxLength(100);
            entity.Property(e => e.name).HasMaxLength(255);

            entity.HasOne(d => d.content_type).WithMany(p => p.auth_permissions)
                .HasForeignKey(d => d.content_type_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_content_type_id");
        });

        modelBuilder.Entity<auth_user>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_use__3213E83F1B028A3A");

            entity.ToTable("auth_user");

            entity.HasIndex(e => e.username, "UQ__auth_use__F3DBC57244641B31").IsUnique();

            entity.Property(e => e.date_joined).HasColumnType("datetime");
            entity.Property(e => e.email).HasMaxLength(254);
            entity.Property(e => e.emp_pin).HasMaxLength(30);
            entity.Property(e => e.first_name).HasMaxLength(30);
            entity.Property(e => e.last_login).HasColumnType("datetime");
            entity.Property(e => e.last_name).HasMaxLength(30);
            entity.Property(e => e.login_ip).HasMaxLength(32);
            entity.Property(e => e.password).HasMaxLength(128);
            entity.Property(e => e.photo).HasMaxLength(200);
            entity.Property(e => e.session_key).HasMaxLength(32);
            entity.Property(e => e.tele_phone).HasMaxLength(30);
            entity.Property(e => e.update_time).HasColumnType("datetime");
            entity.Property(e => e.username).HasMaxLength(30);
        });

        modelBuilder.Entity<auth_user_auth_area>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_use__3213E83FE3B71CFF");

            entity.ToTable("auth_user_auth_area");

            entity.HasIndex(e => e.area_id, "auth_user_auth_area_area_id_d1e54c70");

            entity.HasIndex(e => e.myuser_id, "auth_user_auth_area_myuser_id_5fb9a803");

            entity.HasIndex(e => new { e.myuser_id, e.area_id }, "auth_user_auth_area_myuser_id_area_id_02a19d63_uniq").IsUnique();

            entity.HasOne(d => d.area).WithMany(p => p.auth_user_auth_areas)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_area_area_id_d1e54c70_fk_personnel_area_id");

            entity.HasOne(d => d.myuser).WithMany(p => p.auth_user_auth_areas)
                .HasForeignKey(d => d.myuser_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_area_myuser_id_5fb9a803_fk_auth_user_id");
        });

        modelBuilder.Entity<auth_user_auth_dept>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_use__3213E83F0FCC3D4D");

            entity.ToTable("auth_user_auth_dept");

            entity.HasIndex(e => e.department_id, "auth_user_auth_dept_department_id_5866c514");

            entity.HasIndex(e => e.myuser_id, "auth_user_auth_dept_myuser_id_18a51b27");

            entity.HasIndex(e => new { e.myuser_id, e.department_id }, "auth_user_auth_dept_myuser_id_department_id_61d83386_uniq").IsUnique();

            entity.HasOne(d => d.department).WithMany(p => p.auth_user_auth_depts)
                .HasForeignKey(d => d.department_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_dept_department_id_5866c514_fk_personnel_department_id");

            entity.HasOne(d => d.myuser).WithMany(p => p.auth_user_auth_depts)
                .HasForeignKey(d => d.myuser_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_auth_dept_myuser_id_18a51b27_fk_auth_user_id");
        });

        modelBuilder.Entity<auth_user_group>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_use__3213E83F9DA4A750");

            entity.HasIndex(e => e.group_id, "auth_user_groups_group_id_97559544");

            entity.HasIndex(e => e.myuser_id, "auth_user_groups_myuser_id_d03e8dcc");

            entity.HasIndex(e => new { e.myuser_id, e.group_id }, "auth_user_groups_myuser_id_group_id_664bdfc3_uniq").IsUnique();

            entity.HasOne(d => d.group).WithMany(p => p.auth_user_groups)
                .HasForeignKey(d => d.group_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

            entity.HasOne(d => d.myuser).WithMany(p => p.auth_user_groups)
                .HasForeignKey(d => d.myuser_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_myuser_id_d03e8dcc_fk_auth_user_id");
        });

        modelBuilder.Entity<auth_user_profile>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_use__3213E83F82A40940");

            entity.ToTable("auth_user_profile");

            entity.HasIndex(e => e.user_id, "UQ__auth_use__B9BE370EADB74DF7").IsUnique();

            entity.Property(e => e.login_name).HasMaxLength(30);
            entity.Property(e => e.pwd_update_time).HasColumnType("datetime");

            entity.HasOne(d => d.user).WithOne(p => p.auth_user_profile)
                .HasForeignKey<auth_user_profile>(d => d.user_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_profile_user_id_f9aded29_fk_auth_user_id");
        });

        modelBuilder.Entity<auth_user_user_permission>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__auth_use__3213E83FC77E26B6");

            entity.HasIndex(e => e.myuser_id, "auth_user_user_permissions_myuser_id_679b1527");

            entity.HasIndex(e => new { e.myuser_id, e.permission_id }, "auth_user_user_permissions_myuser_id_permission_id_a558717f_uniq").IsUnique();

            entity.HasIndex(e => e.permission_id, "auth_user_user_permissions_permission_id_1fbb5f2c");

            entity.HasOne(d => d.myuser).WithMany(p => p.auth_user_user_permissions)
                .HasForeignKey(d => d.myuser_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permissions_myuser_id_679b1527_fk_auth_user_id");

            entity.HasOne(d => d.permission).WithMany(p => p.auth_user_user_permissions)
                .HasForeignKey(d => d.permission_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permissions_permission_id_1fbb5f2c_fk_auth_permission_id");
        });

        modelBuilder.Entity<authtoken_token>(entity =>
        {
            entity.HasKey(e => e.key).HasName("PK__authtoke__DFD83CAEE3FD0679");

            entity.ToTable("authtoken_token");

            entity.HasIndex(e => e.user_id, "UQ__authtoke__B9BE370E43536C96").IsUnique();

            entity.Property(e => e.key).HasMaxLength(40);
            entity.Property(e => e.created).HasColumnType("datetime");

            entity.HasOne(d => d.user).WithOne(p => p.authtoken_token)
                .HasForeignKey<authtoken_token>(d => d.user_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("authtoken_token_user_id_35299eff_fk_auth_user_id");
        });

        modelBuilder.Entity<base_adminlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_adm__3213E83FA4B6B045");

            entity.ToTable("base_adminlog");

            entity.HasIndex(e => e.content_type_id, "base_adminlog_content_type_id_3e553c30");

            entity.HasIndex(e => e.user_id, "base_adminlog_user_id_ecf659f8");

            entity.Property(e => e.action).HasMaxLength(50);
            entity.Property(e => e.ip_address).HasMaxLength(39);
            entity.Property(e => e.op_time).HasColumnType("datetime");

            entity.HasOne(d => d.content_type).WithMany(p => p.base_adminlogs)
                .HasForeignKey(d => d.content_type_id)
                .HasConstraintName("base_adminlog_content_type_id_3e553c30_fk_django_content_type_id");

            entity.HasOne(d => d.user).WithMany(p => p.base_adminlogs)
                .HasForeignKey(d => d.user_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("base_adminlog_user_id_ecf659f8_fk_auth_user_id");
        });

        modelBuilder.Entity<base_attparamdept>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_att__3213E83F3EF07E9D");

            entity.HasIndex(e => e.rulename, "UQ__base_att__14AA806DCDC722DD").IsUnique();

            entity.Property(e => e._operator)
                .HasMaxLength(20)
                .HasColumnName("operator");
            entity.Property(e => e.optime).HasColumnType("datetime");
            entity.Property(e => e.rulename).HasMaxLength(40);
        });

        modelBuilder.Entity<base_autoattexporttask>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_aut__3213E83FE74EA489");

            entity.ToTable("base_autoattexporttask");

            entity.HasIndex(e => e.task_code, "UQ__base_aut__4ED2915622BE2F44").IsUnique();

            entity.Property(e => e._params).HasColumnName("params");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.process_time).HasColumnType("datetime");
            entity.Property(e => e.task_code).HasMaxLength(30);
            entity.Property(e => e.task_name).HasMaxLength(30);
        });

        modelBuilder.Entity<base_autoexporttask>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_aut__3213E83FE7FB94FB");

            entity.ToTable("base_autoexporttask");

            entity.HasIndex(e => e.task_code, "UQ__base_aut__4ED29156F6954F68").IsUnique();

            entity.Property(e => e._params).HasColumnName("params");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.process_time).HasColumnType("datetime");
            entity.Property(e => e.task_code).HasMaxLength(30);
            entity.Property(e => e.task_name).HasMaxLength(30);
        });

        modelBuilder.Entity<base_autoimporttask>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_aut__3213E83FE0F3D7F6");

            entity.ToTable("base_autoimporttask");

            entity.HasIndex(e => e.task_code, "UQ__base_aut__4ED29156049EE0E7").IsUnique();

            entity.HasIndex(e => e.company_id, "base_autoimporttask_company_id_d18431a1");

            entity.Property(e => e._params).HasColumnName("params");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.process_time).HasColumnType("datetime");
            entity.Property(e => e.task_code).HasMaxLength(30);
            entity.Property(e => e.task_name).HasMaxLength(30);

            entity.HasOne(d => d.company).WithMany(p => p.base_autoimporttasks)
                .HasForeignKey(d => d.company_id)
                .HasConstraintName("base_autoimporttask_company_id_d18431a1_fk_personnel_company_id");
        });

        modelBuilder.Entity<base_bookmark>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_boo__3213E83FFA1D51C0");

            entity.ToTable("base_bookmark");

            entity.HasIndex(e => e.content_type_id, "base_bookmark_content_type_id_b6a0e799");

            entity.HasIndex(e => e.user_id, "base_bookmark_user_id_5f2d5ca2");

            entity.Property(e => e.filters).HasMaxLength(1000);
            entity.Property(e => e.time_saved).HasColumnType("datetime");
            entity.Property(e => e.title).HasMaxLength(128);

            entity.HasOne(d => d.content_type).WithMany(p => p.base_bookmarks)
                .HasForeignKey(d => d.content_type_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("base_bookmark_content_type_id_b6a0e799_fk_django_content_type_id");

            entity.HasOne(d => d.user).WithMany(p => p.base_bookmarks)
                .HasForeignKey(d => d.user_id)
                .HasConstraintName("base_bookmark_user_id_5f2d5ca2_fk_auth_user_id");
        });

        modelBuilder.Entity<base_dbbackuplog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_dbb__3213E83F1AD7499A");

            entity.ToTable("base_dbbackuplog");

            entity.Property(e => e._operator)
                .HasMaxLength(50)
                .HasColumnName("operator");
            entity.Property(e => e.backup_file).HasMaxLength(100);
            entity.Property(e => e.backup_time).HasColumnType("datetime");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.db_name).HasMaxLength(50);
            entity.Property(e => e.db_type).HasMaxLength(50);
        });

        modelBuilder.Entity<base_emailtemplate>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_ema__3213E83F72EC6AF2");

            entity.ToTable("base_emailtemplate");

            entity.Property(e => e._event).HasColumnName("event");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.subject).HasMaxLength(100);
        });

        modelBuilder.Entity<base_eventalertsetting>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_eve__3213E83FA04A9A84");

            entity.ToTable("base_eventalertsetting");

            entity.Property(e => e._event)
                .HasMaxLength(50)
                .HasColumnName("event");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.module).HasMaxLength(50);
            entity.Property(e => e.sub_module).HasMaxLength(50);
        });

        modelBuilder.Entity<base_fixedexporttask>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_fix__3213E83FE21568ED");

            entity.ToTable("base_fixedexporttask");

            entity.HasIndex(e => e.task_code, "UQ__base_fix__4ED291564D428DAB").IsUnique();

            entity.Property(e => e._params).HasColumnName("params");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.process_time).HasColumnType("datetime");
            entity.Property(e => e.task_code).HasMaxLength(30);
            entity.Property(e => e.task_name).HasMaxLength(30);
        });

        modelBuilder.Entity<base_linenotifysetting>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_lin__3213E83FDF7CF478");

            entity.ToTable("base_linenotifysetting");

            entity.HasIndex(e => e.line_notify_dept_id, "base_linenotifysetting_line_notify_dept_id_0643a5ed");

            entity.HasIndex(e => new { e.line_notify_dept_id, e.line_notify_token, e.message_type }, "base_linenotifysetting_line_notify_dept_id_line_notify_token_message_type_dd79374f_uniq").IsUnique();

            entity.Property(e => e.line_notify_token).HasMaxLength(200);
            entity.Property(e => e.message_head).HasMaxLength(100);
            entity.Property(e => e.message_tail).HasMaxLength(100);
            entity.Property(e => e.push_time).HasColumnType("datetime");
            entity.Property(e => e.remark).HasMaxLength(200);

            entity.HasOne(d => d.line_notify_dept).WithMany(p => p.base_linenotifysettings)
                .HasForeignKey(d => d.line_notify_dept_id)
                .HasConstraintName("base_linenotifysetting_line_notify_dept_id_0643a5ed_fk_personnel_department_id");
        });

        modelBuilder.Entity<base_securitypolicy>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_sec__3213E83F5D62CA9C");

            entity.ToTable("base_securitypolicy");

            entity.Property(e => e.export_encryption_password).HasMaxLength(20);
        });

        modelBuilder.Entity<base_sendemail>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_sen__3213E83F1DCBBEB5");

            entity.ToTable("base_sendemail");

            entity.Property(e => e.email_subject).HasMaxLength(40);
            entity.Property(e => e.send_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<base_sftpsetting>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_sft__3213E83FF5E1B18D");

            entity.ToTable("base_sftpsetting");

            entity.Property(e => e.host).HasMaxLength(39);
            entity.Property(e => e.user_name).HasMaxLength(30);
            entity.Property(e => e.user_password).HasMaxLength(128);
        });

        modelBuilder.Entity<base_sysparam>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_sys__3213E83F31F9AA49");

            entity.ToTable("base_sysparam");

            entity.HasIndex(e => new { e.para_name, e.para_type }, "base_sysparam_para_name_para_type_3086789a_uniq").IsUnique();

            entity.Property(e => e.para_name).HasMaxLength(30);
            entity.Property(e => e.para_type).HasMaxLength(10);
            entity.Property(e => e.para_value).HasMaxLength(250);
        });

        modelBuilder.Entity<base_sysparamdept>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_sys__3213E83F6A125BA6");

            entity.ToTable("base_sysparamdept");

            entity.HasIndex(e => e.rule_name, "UQ__base_sys__B9ADD0FA70017C93").IsUnique();

            entity.Property(e => e._operator)
                .HasMaxLength(20)
                .HasColumnName("operator");
            entity.Property(e => e.op_time).HasColumnType("datetime");
            entity.Property(e => e.rule_name).HasMaxLength(40);
        });

        modelBuilder.Entity<base_systemlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_sys__3213E83F479CDF71");

            entity.ToTable("base_systemlog");

            entity.Property(e => e.execute_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<base_systemsetting>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_sys__3213E83FE45CBDAE");

            entity.ToTable("base_systemsetting");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.name).HasMaxLength(30);
        });

        modelBuilder.Entity<base_whatsapplog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__base_wha__3213E83F1D62B82B");

            entity.ToTable("base_whatsapplog");

            entity.Property(e => e.content).HasMaxLength(300);
            entity.Property(e => e.push_time).HasColumnType("datetime");
            entity.Property(e => e.reason).HasMaxLength(300);
            entity.Property(e => e.receiver).HasMaxLength(50);
        });

        modelBuilder.Entity<django_admin_log>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_a__3213E83FCA97EE6B");

            entity.ToTable("django_admin_log");

            entity.HasIndex(e => e.content_type_id, "django_admin_log_content_type_id_c4bce8eb");

            entity.HasIndex(e => e.user_id, "django_admin_log_user_id_c564eba6");

            entity.Property(e => e.action_time).HasColumnType("datetime");
            entity.Property(e => e.object_repr).HasMaxLength(200);

            entity.HasOne(d => d.content_type).WithMany(p => p.django_admin_logs)
                .HasForeignKey(d => d.content_type_id)
                .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_content_type_id");

            entity.HasOne(d => d.user).WithMany(p => p.django_admin_logs)
                .HasForeignKey(d => d.user_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
        });

        modelBuilder.Entity<django_celery_beat_clockedschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_c__3213E83F78D44537");

            entity.ToTable("django_celery_beat_clockedschedule");

            entity.Property(e => e.clocked_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<django_celery_beat_crontabschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_c__3213E83FDE35ADC0");

            entity.ToTable("django_celery_beat_crontabschedule");

            entity.Property(e => e.day_of_month).HasMaxLength(124);
            entity.Property(e => e.day_of_week).HasMaxLength(64);
            entity.Property(e => e.hour).HasMaxLength(96);
            entity.Property(e => e.minute).HasMaxLength(240);
            entity.Property(e => e.month_of_year).HasMaxLength(64);
            entity.Property(e => e.timezone).HasMaxLength(63);
        });

        modelBuilder.Entity<django_celery_beat_intervalschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_c__3213E83F821D49ED");

            entity.ToTable("django_celery_beat_intervalschedule");

            entity.Property(e => e.period).HasMaxLength(24);
        });

        modelBuilder.Entity<django_celery_beat_periodictask>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_c__3213E83FFBC5D481");

            entity.ToTable("django_celery_beat_periodictask");

            entity.HasIndex(e => e.name, "UQ__django_c__72E12F1BBE3D828F").IsUnique();

            entity.HasIndex(e => e.clocked_id, "django_celery_beat_periodictask_clocked_id_47a69f82");

            entity.HasIndex(e => e.crontab_id, "django_celery_beat_periodictask_crontab_id_d3cba168");

            entity.HasIndex(e => e.interval_id, "django_celery_beat_periodictask_interval_id_a8ca27da");

            entity.HasIndex(e => e.solar_id, "django_celery_beat_periodictask_solar_id_a87ce72c");

            entity.Property(e => e.date_changed).HasColumnType("datetime");
            entity.Property(e => e.exchange).HasMaxLength(200);
            entity.Property(e => e.expires).HasColumnType("datetime");
            entity.Property(e => e.last_run_at).HasColumnType("datetime");
            entity.Property(e => e.name).HasMaxLength(200);
            entity.Property(e => e.queue).HasMaxLength(200);
            entity.Property(e => e.routing_key).HasMaxLength(200);
            entity.Property(e => e.start_time).HasColumnType("datetime");
            entity.Property(e => e.task).HasMaxLength(200);

            entity.HasOne(d => d.clocked).WithMany(p => p.django_celery_beat_periodictasks)
                .HasForeignKey(d => d.clocked_id)
                .HasConstraintName("django_celery_beat_periodictask_clocked_id_47a69f82_fk_django_celery_beat_clockedschedule_id");

            entity.HasOne(d => d.crontab).WithMany(p => p.django_celery_beat_periodictasks)
                .HasForeignKey(d => d.crontab_id)
                .HasConstraintName("django_celery_beat_periodictask_crontab_id_d3cba168_fk_django_celery_beat_crontabschedule_id");

            entity.HasOne(d => d.interval).WithMany(p => p.django_celery_beat_periodictasks)
                .HasForeignKey(d => d.interval_id)
                .HasConstraintName("django_celery_beat_periodictask_interval_id_a8ca27da_fk_django_celery_beat_intervalschedule_id");

            entity.HasOne(d => d.solar).WithMany(p => p.django_celery_beat_periodictasks)
                .HasForeignKey(d => d.solar_id)
                .HasConstraintName("django_celery_beat_periodictask_solar_id_a87ce72c_fk_django_celery_beat_solarschedule_id");
        });

        modelBuilder.Entity<django_celery_beat_periodictask1>(entity =>
        {
            entity.HasKey(e => e.ident).HasName("PK__django_c__07D87A799C5C7E66");

            entity.ToTable("django_celery_beat_periodictasks");

            entity.Property(e => e.ident).ValueGeneratedNever();
            entity.Property(e => e.last_update).HasColumnType("datetime");
        });

        modelBuilder.Entity<django_celery_beat_solarschedule>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_c__3213E83F396FE47D");

            entity.ToTable("django_celery_beat_solarschedule");

            entity.HasIndex(e => new { e._event, e.latitude, e.longitude }, "django_celery_beat_solarschedule_event_latitude_longitude_ba64999a_uniq").IsUnique();

            entity.Property(e => e._event)
                .HasMaxLength(24)
                .HasColumnName("event");
            entity.Property(e => e.latitude).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.longitude).HasColumnType("numeric(9, 6)");
        });

        modelBuilder.Entity<django_content_type>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_c__3213E83F6FEB6096");

            entity.ToTable("django_content_type");

            entity.HasIndex(e => new { e.app_label, e.model }, "django_content_type_app_label_model_76bd3d3b_uniq").IsUnique();

            entity.Property(e => e.app_label).HasMaxLength(100);
            entity.Property(e => e.model).HasMaxLength(100);
        });

        modelBuilder.Entity<django_migration>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__django_m__3213E83F35011FEE");

            entity.Property(e => e.app).HasMaxLength(255);
            entity.Property(e => e.applied).HasColumnType("datetime");
            entity.Property(e => e.name).HasMaxLength(255);
        });

        modelBuilder.Entity<django_session>(entity =>
        {
            entity.HasKey(e => e.session_key).HasName("PK__django_s__B3BA0F1FABA972F1");

            entity.ToTable("django_session");

            entity.HasIndex(e => e.expire_date, "django_session_expire_date_a5c62663");

            entity.Property(e => e.session_key).HasMaxLength(40);
            entity.Property(e => e.expire_date).HasColumnType("datetime");
        });

        modelBuilder.Entity<ep_epsetup>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__ep_epset__3213E83FF64828F9");

            entity.ToTable("ep_epsetup");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.temp_warning).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.temp_warning_F).HasColumnType("numeric(4, 1)");
        });

        modelBuilder.Entity<ep_eptransaction>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__ep_eptra__3213E83F47AF61F3");

            entity.ToTable("ep_eptransaction");

            entity.HasIndex(e => new { e.emp_code, e.check_datetime }, "ep_eptransaction_emp_code_check_datetime_0b54f31f_uniq").IsUnique();

            entity.HasIndex(e => e.emp_id, "ep_eptransaction_emp_id_1006883f");

            entity.HasIndex(e => e.terminal_id, "ep_eptransaction_terminal_id_4490b209");

            entity.Property(e => e.area).HasMaxLength(30);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.check_date).HasColumnType("datetime");
            entity.Property(e => e.check_datetime).HasColumnType("datetime");
            entity.Property(e => e.check_time).HasColumnType("datetime");
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.emp_code).HasMaxLength(50);
            entity.Property(e => e.temperature).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.terminal_sn).HasMaxLength(50);
            entity.Property(e => e.upload_time).HasColumnType("datetime");

            entity.HasOne(d => d.emp).WithMany(p => p.ep_eptransactions)
                .HasForeignKey(d => d.emp_id)
                .HasConstraintName("ep_eptransaction_emp_id_1006883f_fk_personnel_employee_id");

            entity.HasOne(d => d.terminal).WithMany(p => p.ep_eptransactions)
                .HasForeignKey(d => d.terminal_id)
                .HasConstraintName("ep_eptransaction_terminal_id_4490b209_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<guardian_groupobjectpermission>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__guardian__3213E83FBCB43531");

            entity.ToTable("guardian_groupobjectpermission");

            entity.HasIndex(e => e.content_type_id, "guardian_groupobjectpermission_content_type_id_7ade36b8");

            entity.HasIndex(e => e.group_id, "guardian_groupobjectpermission_group_id_4bbbfb62");

            entity.HasIndex(e => new { e.group_id, e.permission_id, e.object_pk }, "guardian_groupobjectpermission_group_id_permission_id_object_pk_3f189f7c_uniq").IsUnique();

            entity.HasIndex(e => e.permission_id, "guardian_groupobjectpermission_permission_id_36572738");

            entity.Property(e => e.object_pk).HasMaxLength(255);

            entity.HasOne(d => d.content_type).WithMany(p => p.guardian_groupobjectpermissions)
                .HasForeignKey(d => d.content_type_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_groupobjectpermission_content_type_id_7ade36b8_fk_django_content_type_id");

            entity.HasOne(d => d.group).WithMany(p => p.guardian_groupobjectpermissions)
                .HasForeignKey(d => d.group_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_groupobjectpermission_group_id_4bbbfb62_fk_auth_group_id");

            entity.HasOne(d => d.permission).WithMany(p => p.guardian_groupobjectpermissions)
                .HasForeignKey(d => d.permission_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_groupobjectpermission_permission_id_36572738_fk_auth_permission_id");
        });

        modelBuilder.Entity<guardian_userobjectpermission>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__guardian__3213E83F57F16A44");

            entity.ToTable("guardian_userobjectpermission");

            entity.HasIndex(e => e.content_type_id, "guardian_userobjectpermission_content_type_id_2e892405");

            entity.HasIndex(e => e.permission_id, "guardian_userobjectpermission_permission_id_71807bfc");

            entity.HasIndex(e => e.user_id, "guardian_userobjectpermission_user_id_d5c1e964");

            entity.HasIndex(e => new { e.user_id, e.permission_id, e.object_pk }, "guardian_userobjectpermission_user_id_permission_id_object_pk_b0b3d2fc_uniq").IsUnique();

            entity.Property(e => e.object_pk).HasMaxLength(255);

            entity.HasOne(d => d.content_type).WithMany(p => p.guardian_userobjectpermissions)
                .HasForeignKey(d => d.content_type_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_userobjectpermission_content_type_id_2e892405_fk_django_content_type_id");

            entity.HasOne(d => d.permission).WithMany(p => p.guardian_userobjectpermissions)
                .HasForeignKey(d => d.permission_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_userobjectpermission_permission_id_71807bfc_fk_auth_permission_id");

            entity.HasOne(d => d.user).WithMany(p => p.guardian_userobjectpermissions)
                .HasForeignKey(d => d.user_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("guardian_userobjectpermission_user_id_d5c1e964_fk_auth_user_id");
        });

        modelBuilder.Entity<iclock_biodatum>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_b__3213E83F07FAF572");

            entity.HasIndex(e => new { e.employee_id, e.bio_no, e.bio_index, e.bio_type, e.bio_format, e.major_ver, e.minor_ver }, "iclock_biodata_employee_id_bio_no_bio_index_bio_type_bio_format_major_ver_minor_ver_bc5286ed_uniq").IsUnique();

            entity.HasIndex(e => e.employee_id, "iclock_biodata_employee_id_ff748ea7");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.major_ver).HasMaxLength(30);
            entity.Property(e => e.minor_ver).HasMaxLength(30);
            entity.Property(e => e.sn).HasMaxLength(50);
            entity.Property(e => e.update_time).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.iclock_biodata)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_biodata_employee_id_ff748ea7_fk_personnel_employee_id");
        });

        modelBuilder.Entity<iclock_biophoto>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_b__3213E83FB3BBB8B0");

            entity.ToTable("iclock_biophoto");

            entity.HasIndex(e => e.employee_id, "iclock_biophoto_employee_id_3dba5819");

            entity.Property(e => e.approval_photo).HasMaxLength(100);
            entity.Property(e => e.approval_time).HasColumnType("datetime");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.email).HasMaxLength(254);
            entity.Property(e => e.enroll_sn).HasMaxLength(50);
            entity.Property(e => e.first_name).HasMaxLength(100);
            entity.Property(e => e.last_name).HasMaxLength(50);
            entity.Property(e => e.register_photo).HasMaxLength(100);
            entity.Property(e => e.register_time).HasColumnType("datetime");
            entity.Property(e => e.remark).HasMaxLength(100);

            entity.HasOne(d => d.employee).WithMany(p => p.iclock_biophotos)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_biophoto_employee_id_3dba5819_fk_personnel_employee_id");
        });

        modelBuilder.Entity<iclock_devicemoduleconfig>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_d__3213E83F28E3D65B");

            entity.ToTable("iclock_devicemoduleconfig");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.sync_time).HasMaxLength(100);
            entity.Property(e => e.transfer_time).HasMaxLength(100);
        });

        modelBuilder.Entity<iclock_errorcommandlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_e__3213E83F377D6C37");

            entity.ToTable("iclock_errorcommandlog");

            entity.HasIndex(e => e.terminal_id, "iclock_errorcommandlog_terminal_id_3b2d7cbd");

            entity.Property(e => e.cmd).HasMaxLength(50);
            entity.Property(e => e.error_code).HasMaxLength(16);
            entity.Property(e => e.error_msg).HasMaxLength(50);
            entity.Property(e => e.upload_time).HasColumnType("datetime");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_errorcommandlogs)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_errorcommandlog_terminal_id_3b2d7cbd_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_privatemessage>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_p__3213E83F599811B7");

            entity.ToTable("iclock_privatemessage");

            entity.HasIndex(e => e.employee_id, "iclock_privatemessage_employee_id_e84a34c0");

            entity.HasIndex(e => e.message_id, "iclock_privatemessage_message_id_e3145d3b");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.last_send).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.iclock_privatemessages)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_privatemessage_employee_id_e84a34c0_fk_personnel_employee_id");

            entity.HasOne(d => d.message).WithMany(p => p.iclock_privatemessages)
                .HasForeignKey(d => d.message_id)
                .HasConstraintName("iclock_privatemessage_message_id_e3145d3b_fk_iclock_shortmessage_id");
        });

        modelBuilder.Entity<iclock_publicmessage>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_p__3213E83FC11490B7");

            entity.ToTable("iclock_publicmessage");

            entity.HasIndex(e => e.message_id, "iclock_publicmessage_message_id_7d125e28");

            entity.HasIndex(e => e.terminal_id, "iclock_publicmessage_terminal_id_c3b5e4cf");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.last_send).HasColumnType("datetime");

            entity.HasOne(d => d.message).WithMany(p => p.iclock_publicmessages)
                .HasForeignKey(d => d.message_id)
                .HasConstraintName("iclock_publicmessage_message_id_7d125e28_fk_iclock_shortmessage_id");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_publicmessages)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_publicmessage_terminal_id_c3b5e4cf_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_shortmessage>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_s__3213E83FA3377117");

            entity.ToTable("iclock_shortmessage");

            entity.Property(e => e.msg_type).HasMaxLength(5);
            entity.Property(e => e.start_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<iclock_terminal>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83F8C21BDCB");

            entity.ToTable("iclock_terminal");

            entity.HasIndex(e => e.sn, "UQ__iclock_t__3214186DD5D1AD8B").IsUnique();

            entity.HasIndex(e => e.area_id, "iclock_terminal_area_id_c019c6f0");

            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.capture_stamp).HasMaxLength(30);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.face_alg_ver).HasMaxLength(10);
            entity.Property(e => e.fp_alg_ver).HasMaxLength(10);
            entity.Property(e => e.fv_alg_ver).HasMaxLength(10);
            entity.Property(e => e.fw_ver).HasMaxLength(100);
            entity.Property(e => e.ip_address).HasMaxLength(39);
            entity.Property(e => e.last_activity).HasColumnType("datetime");
            entity.Property(e => e.log_stamp).HasMaxLength(30);
            entity.Property(e => e.oem_vendor).HasMaxLength(50);
            entity.Property(e => e.op_log_stamp).HasMaxLength(30);
            entity.Property(e => e.palm_alg_ver).HasMaxLength(10);
            entity.Property(e => e.platform).HasMaxLength(30);
            entity.Property(e => e.push_protocol).HasMaxLength(30);
            entity.Property(e => e.push_time).HasColumnType("datetime");
            entity.Property(e => e.push_ver).HasMaxLength(30);
            entity.Property(e => e.real_ip).HasMaxLength(39);
            entity.Property(e => e.sn).HasMaxLength(50);
            entity.Property(e => e.style).HasMaxLength(20);
            entity.Property(e => e.terminal_name).HasMaxLength(30);
            entity.Property(e => e.transfer_time).HasMaxLength(100);
            entity.Property(e => e.upload_flag).HasMaxLength(10);
            entity.Property(e => e.upload_time).HasColumnType("datetime");

            entity.HasOne(d => d.area).WithMany(p => p.iclock_terminals)
                .HasForeignKey(d => d.area_id)
                .HasConstraintName("iclock_terminal_area_id_c019c6f0_fk_personnel_area_id");
        });

        modelBuilder.Entity<iclock_terminalcommand>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83FB34E6FC1");

            entity.ToTable("iclock_terminalcommand");

            entity.HasIndex(e => e.terminal_id, "iclock_terminalcommand_terminal_id_3dcf836f");

            entity.Property(e => e.commit_time).HasColumnType("datetime");
            entity.Property(e => e.return_time).HasColumnType("datetime");
            entity.Property(e => e.transfer_time).HasColumnType("datetime");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_terminalcommands)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminalcommand_terminal_id_3dcf836f_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_terminalcommandlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83F40BB4D30");

            entity.ToTable("iclock_terminalcommandlog");

            entity.HasIndex(e => e.terminal_id, "iclock_terminalcommandlog_terminal_id_35ea8b2b");

            entity.Property(e => e.commit_time).HasColumnType("datetime");
            entity.Property(e => e.return_time).HasColumnType("datetime");
            entity.Property(e => e.transfer_time).HasColumnType("datetime");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_terminalcommandlogs)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminalcommandlog_terminal_id_35ea8b2b_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_terminalemployee>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83F5F1552CD");

            entity.ToTable("iclock_terminalemployee");

            entity.Property(e => e.emp_code).HasMaxLength(20);
            entity.Property(e => e.terminal_sn).HasMaxLength(50);
        });

        modelBuilder.Entity<iclock_terminallog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83FDB6B63C0");

            entity.ToTable("iclock_terminallog");

            entity.HasIndex(e => e.terminal_id, "iclock_terminallog_terminal_id_667b3ea7");

            entity.Property(e => e._object)
                .HasMaxLength(50)
                .HasColumnName("object");
            entity.Property(e => e.action_time).HasColumnType("datetime");
            entity.Property(e => e.admin).HasMaxLength(50);
            entity.Property(e => e.upload_time).HasColumnType("datetime");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_terminallogs)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminallog_terminal_id_667b3ea7_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_terminalparameter>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83FAB9CE792");

            entity.ToTable("iclock_terminalparameter");

            entity.HasIndex(e => e.terminal_id, "iclock_terminalparameter_terminal_id_443872e3");

            entity.HasIndex(e => new { e.terminal_id, e.param_name }, "iclock_terminalparameter_terminal_id_param_name_8abbb5c0_uniq").IsUnique();

            entity.Property(e => e.param_name).HasMaxLength(30);
            entity.Property(e => e.param_type).HasMaxLength(10);
            entity.Property(e => e.param_value).HasMaxLength(100);

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_terminalparameters)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminalparameter_terminal_id_443872e3_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_terminaluploadlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83F864F9EF9");

            entity.ToTable("iclock_terminaluploadlog");

            entity.HasIndex(e => e.terminal_id, "iclock_terminaluploadlog_terminal_id_9c9a7664");

            entity.Property(e => e._event)
                .HasMaxLength(80)
                .HasColumnName("event");
            entity.Property(e => e.content).HasMaxLength(80);
            entity.Property(e => e.upload_time).HasColumnType("datetime");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_terminaluploadlogs)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_terminaluploadlog_terminal_id_9c9a7664_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_terminalworkcode>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83F8AC7BDEF");

            entity.ToTable("iclock_terminalworkcode");

            entity.HasIndex(e => e.code, "UQ__iclock_t__357D4CF9ED153EBD").IsUnique();

            entity.HasIndex(e => e.company_id, "iclock_terminalworkcode_company_id_77625f26");

            entity.Property(e => e.alias).HasMaxLength(24);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.code).HasMaxLength(8);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.last_activity).HasColumnType("datetime");

            entity.HasOne(d => d.company).WithMany(p => p.iclock_terminalworkcodes)
                .HasForeignKey(d => d.company_id)
                .HasConstraintName("iclock_terminalworkcode_company_id_77625f26_fk_personnel_company_id");
        });

        modelBuilder.Entity<iclock_transaction>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83F2CDE3856");

            entity.ToTable("iclock_transaction");

            entity.HasIndex(e => new { e.company_code, e.emp_code, e.punch_time }, "iclock_transaction_company_code_emp_code_punch_time_2665c3d7_uniq").IsUnique();

            entity.HasIndex(e => e.emp_id, "iclock_transaction_emp_id_60fa3521");

            entity.HasIndex(e => e.terminal_id, "iclock_transaction_terminal_id_451c81c2");

            entity.Property(e => e.area_alias).HasMaxLength(30);
            entity.Property(e => e.company_code).HasMaxLength(50);
            entity.Property(e => e.crc).HasMaxLength(100);
            entity.Property(e => e.emp_code).HasMaxLength(20);
            entity.Property(e => e.gps_location).HasMaxLength(300);
            entity.Property(e => e.mobile).HasMaxLength(50);
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");
            entity.Property(e => e.reserved).HasMaxLength(100);
            entity.Property(e => e.sync_time).HasColumnType("datetime");
            entity.Property(e => e.temperature).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.terminal_alias).HasMaxLength(50);
            entity.Property(e => e.terminal_sn).HasMaxLength(50);
            entity.Property(e => e.upload_time).HasColumnType("datetime");
            entity.Property(e => e.work_code).HasMaxLength(20);

            entity.HasOne(d => d.emp).WithMany(p => p.iclock_transactions)
                .HasForeignKey(d => d.emp_id)
                .HasConstraintName("iclock_transaction_emp_id_60fa3521_fk_personnel_employee_id");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_transactions)
                .HasForeignKey(d => d.terminal_id)
                .HasConstraintName("iclock_transaction_terminal_id_451c81c2_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<iclock_transactionproofcmd>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__iclock_t__3213E83FF35058AC");

            entity.ToTable("iclock_transactionproofcmd");

            entity.HasIndex(e => e.terminal_id, "iclock_transactionproofcmd_terminal_id_08b81e1e");

            entity.Property(e => e.action_time).HasColumnType("datetime");
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.reserved_char).HasMaxLength(30);
            entity.Property(e => e.start_time).HasColumnType("datetime");

            entity.HasOne(d => d.terminal).WithMany(p => p.iclock_transactionproofcmds)
                .HasForeignKey(d => d.terminal_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("iclock_transactionproofcmd_terminal_id_08b81e1e_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<meeting_meetingentity>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__meeting___2F050E15CDD0F5B9");

            entity.ToTable("meeting_meetingentity");

            entity.HasIndex(e => e.code, "UQ__meeting___357D4CF95D163607").IsUnique();

            entity.HasIndex(e => e.room_id, "meeting_meetingentity_room_id_bc2c738e");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.apply_reason).HasMaxLength(200);
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.auto_recording).HasMaxLength(50);
            entity.Property(e => e.calculation_time).HasColumnType("datetime");
            entity.Property(e => e.code).HasMaxLength(32);
            entity.Property(e => e.content).HasMaxLength(200);
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.in_end).HasColumnType("datetime");
            entity.Property(e => e.in_start).HasColumnType("datetime");
            entity.Property(e => e.meeting_date).HasColumnType("datetime");
            entity.Property(e => e.out_end).HasColumnType("datetime");
            entity.Property(e => e.out_start).HasColumnType("datetime");
            entity.Property(e => e.start_time).HasColumnType("datetime");
            entity.Property(e => e.sync_time).HasColumnType("datetime");
            entity.Property(e => e.view_date).HasColumnType("datetime");
            entity.Property(e => e.virutal_uuid).HasMaxLength(50);

            entity.HasOne(d => d.room).WithMany(p => p.meeting_meetingentities)
                .HasForeignKey(d => d.room_id)
                .HasConstraintName("meeting_meetingentity_room_id_bc2c738e_fk_meeting_meetingroom_id");

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.meeting_meetingentity)
                .HasForeignKey<meeting_meetingentity>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingentity_workflowinstance_ptr_id_dbd9ab40_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<meeting_meetingentity_attender>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__meeting___3213E83F21E1EFE0");

            entity.ToTable("meeting_meetingentity_attender");

            entity.HasIndex(e => e.employee_id, "meeting_meetingentity_attender_employee_id_ee898064");

            entity.HasIndex(e => e.meetingentity_id, "meeting_meetingentity_attender_meetingentity_id_b96dbc7d");

            entity.HasIndex(e => new { e.meetingentity_id, e.employee_id }, "meeting_meetingentity_attender_meetingentity_id_employee_id_b556fc2d_uniq").IsUnique();

            entity.HasOne(d => d.employee).WithMany(p => p.meeting_meetingentity_attenders)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingentity_attender_employee_id_ee898064_fk_personnel_employee_id");

            entity.HasOne(d => d.meetingentity).WithMany(p => p.meeting_meetingentity_attenders)
                .HasForeignKey(d => d.meetingentity_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingentity_attender_meetingentity_id_b96dbc7d_fk_meeting_meetingentity_workflowinstance_ptr_id");
        });

        modelBuilder.Entity<meeting_meetingmanuallog>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__meeting___2F050E158261B790");

            entity.ToTable("meeting_meetingmanuallog");

            entity.HasIndex(e => e.meeting_id, "meeting_meetingmanuallog_meeting_id_a672eaaf");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_reason).HasMaxLength(200);
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");

            entity.HasOne(d => d.meeting).WithMany(p => p.meeting_meetingmanuallogs)
                .HasForeignKey(d => d.meeting_id)
                .HasConstraintName("meeting_meetingmanuallog_meeting_id_a672eaaf_fk_meeting_meetingentity_workflowinstance_ptr_id");

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.meeting_meetingmanuallog)
                .HasForeignKey<meeting_meetingmanuallog>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingmanuallog_workflowinstance_ptr_id_bd514862_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<meeting_meetingpayloadbase>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__meeting___3213E83FF2494A2E");

            entity.ToTable("meeting_meetingpayloadbase");

            entity.HasIndex(e => e.emp_id, "meeting_meetingpayloadbase_emp_id_ed6ec148");

            entity.HasIndex(e => e.meeting_id, "meeting_meetingpayloadbase_meeting_id_ca9d20cc");

            entity.Property(e => e.id)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.clock_in).HasColumnType("datetime");
            entity.Property(e => e.clock_out).HasColumnType("datetime");
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.meeting_date).HasColumnType("datetime");
            entity.Property(e => e.start_time).HasColumnType("datetime");

            entity.HasOne(d => d.emp).WithMany(p => p.meeting_meetingpayloadbases)
                .HasForeignKey(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingpayloadbase_emp_id_ed6ec148_fk_personnel_employee_id");

            entity.HasOne(d => d.meeting).WithMany(p => p.meeting_meetingpayloadbases)
                .HasForeignKey(d => d.meeting_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingpayloadbase_meeting_id_ca9d20cc_fk_meeting_meetingentity_workflowinstance_ptr_id");
        });

        modelBuilder.Entity<meeting_meetingroom>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__meeting___3213E83F6C591270");

            entity.ToTable("meeting_meetingroom");

            entity.HasIndex(e => e.code, "UQ__meeting___357D4CF9C8617BF7").IsUnique();

            entity.Property(e => e.alias).HasMaxLength(50);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.code).HasMaxLength(32);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.location).HasMaxLength(200);
        });

        modelBuilder.Entity<meeting_meetingroomdevice>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__meeting___3213E83F434654C1");

            entity.ToTable("meeting_meetingroomdevice");

            entity.HasIndex(e => e.device_id, "UQ__meeting___3B085D8A87D2DAE9").IsUnique();

            entity.HasIndex(e => e.room_id, "meeting_meetingroomdevice_room_id_e000d78d");

            entity.HasOne(d => d.device).WithOne(p => p.meeting_meetingroomdevice)
                .HasForeignKey<meeting_meetingroomdevice>(d => d.device_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("meeting_meetingroomdevice_device_id_a09e8a7d_fk_iclock_terminal_id");

            entity.HasOne(d => d.room).WithMany(p => p.meeting_meetingroomdevices)
                .HasForeignKey(d => d.room_id)
                .HasConstraintName("meeting_meetingroomdevice_room_id_e000d78d_fk_meeting_meetingroom_id");
        });

        modelBuilder.Entity<meeting_meetingtransaction>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__meeting___3213E83FC5B3660F");

            entity.ToTable("meeting_meetingtransaction");

            entity.HasIndex(e => e.emp_id, "meeting_meetingtransaction_emp_id_fbcdd686");

            entity.HasIndex(e => new { e.emp_id, e.punch_datetime }, "meeting_meetingtransaction_emp_id_punch_datetime_65665dce_uniq").IsUnique();

            entity.HasIndex(e => e.meeting_id, "meeting_meetingtransaction_meeting_id_e4e505e5");

            entity.HasIndex(e => e.terminal_id, "meeting_meetingtransaction_terminal_id_047426f2");

            entity.Property(e => e.emp_code).HasMaxLength(50);
            entity.Property(e => e.punch_date).HasColumnType("datetime");
            entity.Property(e => e.punch_datetime).HasColumnType("datetime");
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");
            entity.Property(e => e.upload_time).HasColumnType("datetime");

            entity.HasOne(d => d.emp).WithMany(p => p.meeting_meetingtransactions)
                .HasForeignKey(d => d.emp_id)
                .HasConstraintName("meeting_meetingtransaction_emp_id_fbcdd686_fk_personnel_employee_id");

            entity.HasOne(d => d.meeting).WithMany(p => p.meeting_meetingtransactions)
                .HasForeignKey(d => d.meeting_id)
                .HasConstraintName("meeting_meetingtransaction_meeting_id_e4e505e5_fk_meeting_meetingentity_workflowinstance_ptr_id");

            entity.HasOne(d => d.terminal).WithMany(p => p.meeting_meetingtransactions)
                .HasForeignKey(d => d.terminal_id)
                .HasConstraintName("meeting_meetingtransaction_terminal_id_047426f2_fk_iclock_terminal_id");
        });

        modelBuilder.Entity<mobile_announcement>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_a__3213E83F3142ABE6");

            entity.ToTable("mobile_announcement");

            entity.HasIndex(e => e.admin_id, "mobile_announcement_admin_id_6af3868c");

            entity.HasIndex(e => e.init_sender_id, "mobile_announcement_init_sender_id_2f5e35bd");

            entity.HasIndex(e => e.receiver_id, "mobile_announcement_receiver_id_ddf2a860");

            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.sender).HasMaxLength(50);
            entity.Property(e => e.subject).HasMaxLength(100);
            entity.Property(e => e.system_sender).HasMaxLength(50);

            entity.HasOne(d => d.admin).WithMany(p => p.mobile_announcements)
                .HasForeignKey(d => d.admin_id)
                .HasConstraintName("mobile_announcement_admin_id_6af3868c_fk_auth_user_id");

            entity.HasOne(d => d.init_sender).WithMany(p => p.mobile_announcementinit_senders)
                .HasForeignKey(d => d.init_sender_id)
                .HasConstraintName("mobile_announcement_init_sender_id_2f5e35bd_fk_personnel_employee_id");

            entity.HasOne(d => d.receiver).WithMany(p => p.mobile_announcementreceivers)
                .HasForeignKey(d => d.receiver_id)
                .HasConstraintName("mobile_announcement_receiver_id_ddf2a860_fk_personnel_employee_id");
        });

        modelBuilder.Entity<mobile_appactionlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_a__3213E83FD6D66A48");

            entity.ToTable("mobile_appactionlog");

            entity.Property(e => e._params).HasColumnName("params");
            entity.Property(e => e.action).HasMaxLength(50);
            entity.Property(e => e.action_time).HasColumnType("datetime");
            entity.Property(e => e.client).HasMaxLength(50);
            entity.Property(e => e.remote_ip).HasMaxLength(20);
            entity.Property(e => e.user).HasMaxLength(20);
        });

        modelBuilder.Entity<mobile_applist>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_a__3213E83F34289621");

            entity.ToTable("mobile_applist");

            entity.Property(e => e.client_id).HasMaxLength(100);
            entity.Property(e => e.last_active).HasColumnType("datetime");
            entity.Property(e => e.login_time).HasColumnType("datetime");
            entity.Property(e => e.username).HasMaxLength(50);
        });

        modelBuilder.Entity<mobile_appnotification>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_a__3213E83F0F8EF721");

            entity.ToTable("mobile_appnotification");

            entity.HasIndex(e => e.admin_id, "mobile_appnotification_admin_id_29c27197");

            entity.HasIndex(e => e.init_sender_id, "mobile_appnotification_init_sender_id_d8aff845");

            entity.HasIndex(e => e.receiver_id, "mobile_appnotification_receiver_id_90c4a355");

            entity.Property(e => e.notification_time).HasColumnType("datetime");
            entity.Property(e => e.read_time).HasColumnType("datetime");
            entity.Property(e => e.sender).HasMaxLength(50);
            entity.Property(e => e.system_sender).HasMaxLength(50);

            entity.HasOne(d => d.admin).WithMany(p => p.mobile_appnotifications)
                .HasForeignKey(d => d.admin_id)
                .HasConstraintName("mobile_appnotification_admin_id_29c27197_fk_auth_user_id");

            entity.HasOne(d => d.init_sender).WithMany(p => p.mobile_appnotificationinit_senders)
                .HasForeignKey(d => d.init_sender_id)
                .HasConstraintName("mobile_appnotification_init_sender_id_d8aff845_fk_personnel_employee_id");

            entity.HasOne(d => d.receiver).WithMany(p => p.mobile_appnotificationreceivers)
                .HasForeignKey(d => d.receiver_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_appnotification_receiver_id_90c4a355_fk_personnel_employee_id");
        });

        modelBuilder.Entity<mobile_gpsfordepartment>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_g__3213E83F2A79B53C");

            entity.ToTable("mobile_gpsfordepartment");

            entity.HasIndex(e => e.department_id, "mobile_gpsfordepartment_department_id_988ccf22");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");

            entity.HasOne(d => d.department).WithMany(p => p.mobile_gpsfordepartments)
                .HasForeignKey(d => d.department_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsfordepartment_department_id_988ccf22_fk_personnel_department_id");
        });

        modelBuilder.Entity<mobile_gpsfordepartment_location>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_g__3213E83F33EFA48D");

            entity.ToTable("mobile_gpsfordepartment_location");

            entity.HasIndex(e => e.gpsfordepartment_id, "mobile_gpsfordepartment_location_gpsfordepartment_id_23e9af3a");

            entity.HasIndex(e => new { e.gpsfordepartment_id, e.gpslocation_id }, "mobile_gpsfordepartment_location_gpsfordepartment_id_gpslocation_id_58226033_uniq").IsUnique();

            entity.HasIndex(e => e.gpslocation_id, "mobile_gpsfordepartment_location_gpslocation_id_48b82e9e");

            entity.HasOne(d => d.gpsfordepartment).WithMany(p => p.mobile_gpsfordepartment_locations)
                .HasForeignKey(d => d.gpsfordepartment_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsfordepartment_location_gpsfordepartment_id_23e9af3a_fk_mobile_gpsfordepartment_id");

            entity.HasOne(d => d.gpslocation).WithMany(p => p.mobile_gpsfordepartment_locations)
                .HasForeignKey(d => d.gpslocation_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsfordepartment_location_gpslocation_id_48b82e9e_fk_mobile_gpslocation_id");
        });

        modelBuilder.Entity<mobile_gpsforemployee>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_g__3213E83FE595D6DC");

            entity.ToTable("mobile_gpsforemployee");

            entity.HasIndex(e => e.employee_id, "mobile_gpsforemployee_employee_id_982b7cef");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.mobile_gpsforemployees)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsforemployee_employee_id_982b7cef_fk_personnel_employee_id");
        });

        modelBuilder.Entity<mobile_gpsforemployee_location>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_g__3213E83F88584C87");

            entity.ToTable("mobile_gpsforemployee_location");

            entity.HasIndex(e => e.gpsforemployee_id, "mobile_gpsforemployee_location_gpsforemployee_id_a52023d5");

            entity.HasIndex(e => new { e.gpsforemployee_id, e.gpslocation_id }, "mobile_gpsforemployee_location_gpsforemployee_id_gpslocation_id_9ceb93bf_uniq").IsUnique();

            entity.HasIndex(e => e.gpslocation_id, "mobile_gpsforemployee_location_gpslocation_id_497a214f");

            entity.HasOne(d => d.gpsforemployee).WithMany(p => p.mobile_gpsforemployee_locations)
                .HasForeignKey(d => d.gpsforemployee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsforemployee_location_gpsforemployee_id_a52023d5_fk_mobile_gpsforemployee_id");

            entity.HasOne(d => d.gpslocation).WithMany(p => p.mobile_gpsforemployee_locations)
                .HasForeignKey(d => d.gpslocation_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mobile_gpsforemployee_location_gpslocation_id_497a214f_fk_mobile_gpslocation_id");
        });

        modelBuilder.Entity<mobile_gpslocation>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_g__3213E83F28EBDDF8");

            entity.ToTable("mobile_gpslocation");

            entity.Property(e => e.alias).HasMaxLength(100);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.location).HasMaxLength(100);
        });

        modelBuilder.Entity<mobile_mobileapirequestlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__mobile_m__3213E83F0A041432");

            entity.ToTable("mobile_mobileapirequestlog");

            entity.HasIndex(e => e.path, "mobile_mobileapirequestlog_path_830043b5");

            entity.HasIndex(e => e.requested_at, "mobile_mobileapirequestlog_requested_at_a8c85067");

            entity.HasIndex(e => e.status_code, "mobile_mobileapirequestlog_status_code_c2de0c48");

            entity.HasIndex(e => e.user_id, "mobile_mobileapirequestlog_user_id_dfd3ded1");

            entity.HasIndex(e => e.view, "mobile_mobileapirequestlog_view_50dbf600");

            entity.HasIndex(e => e.view_method, "mobile_mobileapirequestlog_view_method_2e13cf95");

            entity.Property(e => e.host).HasMaxLength(200);
            entity.Property(e => e.method).HasMaxLength(10);
            entity.Property(e => e.path).HasMaxLength(200);
            entity.Property(e => e.remote_addr).HasMaxLength(39);
            entity.Property(e => e.requested_at).HasColumnType("datetime");
            entity.Property(e => e.username_persistent).HasMaxLength(200);
            entity.Property(e => e.view).HasMaxLength(200);
            entity.Property(e => e.view_method).HasMaxLength(200);

            entity.HasOne(d => d.user).WithMany(p => p.mobile_mobileapirequestlogs)
                .HasForeignKey(d => d.user_id)
                .HasConstraintName("mobile_mobileapirequestlog_user_id_dfd3ded1_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_deductionformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F803D7EDA");

            entity.ToTable("payroll_deductionformula");

            entity.HasIndex(e => e.name, "UQ__payroll___72E12F1BE7F6A360").IsUnique();

            entity.Property(e => e.formula).HasMaxLength(100);
            entity.Property(e => e.name).HasMaxLength(30);
        });

        modelBuilder.Entity<payroll_emploan>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F9F678CCB");

            entity.ToTable("payroll_emploan");

            entity.HasIndex(e => e.employee_id, "payroll_emploan_employee_id_97a251ef");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.loan_clean_time).HasColumnType("datetime");
            entity.Property(e => e.loan_time).HasColumnType("datetime");
            entity.Property(e => e.remark).HasMaxLength(300);

            entity.HasOne(d => d.employee).WithMany(p => p.payroll_emploans)
                .HasForeignKey(d => d.employee_id)
                .HasConstraintName("payroll_emploan_employee_id_97a251ef_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_emppayrollprofile>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83FD55FEFF9");

            entity.ToTable("payroll_emppayrollprofile");

            entity.HasIndex(e => e.employee_id, "UQ__payroll___C52E0BA9D450BF72").IsUnique();

            entity.Property(e => e.agent_account).HasMaxLength(30);
            entity.Property(e => e.agent_id).HasMaxLength(30);
            entity.Property(e => e.bank_account).HasMaxLength(30);
            entity.Property(e => e.bank_name).HasMaxLength(30);
            entity.Property(e => e.personnel_id).HasMaxLength(30);

            entity.HasOne(d => d.employee).WithOne(p => p.payroll_emppayrollprofile)
                .HasForeignKey<payroll_emppayrollprofile>(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_emppayrollprofile_employee_id_6c97078c_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_exceptionformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83FDCEC551E");

            entity.ToTable("payroll_exceptionformula");

            entity.HasIndex(e => e.name, "UQ__payroll___72E12F1BB70CBDFB").IsUnique();

            entity.HasIndex(e => e.pay_code_id, "payroll_exceptionformula_pay_code_id_97609b51");

            entity.Property(e => e.formula).HasMaxLength(100);
            entity.Property(e => e.name).HasMaxLength(30);

            entity.HasOne(d => d.pay_code).WithMany(p => p.payroll_exceptionformulas)
                .HasForeignKey(d => d.pay_code_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_exceptionformula_pay_code_id_97609b51_fk_att_paycode_id");
        });

        modelBuilder.Entity<payroll_extradeduction>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F0A966DE0");

            entity.ToTable("payroll_extradeduction");

            entity.HasIndex(e => e.employee_id, "payroll_extradeduction_employee_id_53072441");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.issued_time).HasColumnType("datetime");
            entity.Property(e => e.remark).HasMaxLength(300);

            entity.HasOne(d => d.employee).WithMany(p => p.payroll_extradeductions)
                .HasForeignKey(d => d.employee_id)
                .HasConstraintName("payroll_extradeduction_employee_id_53072441_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_extraincrease>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F13014BBC");

            entity.ToTable("payroll_extraincrease");

            entity.HasIndex(e => e.employee_id, "payroll_extraincrease_employee_id_f902e6bb");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.issued_time).HasColumnType("datetime");
            entity.Property(e => e.remark).HasMaxLength(300);

            entity.HasOne(d => d.employee).WithMany(p => p.payroll_extraincreases)
                .HasForeignKey(d => d.employee_id)
                .HasConstraintName("payroll_extraincrease_employee_id_f902e6bb_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_increasementformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F0D9E31EF");

            entity.ToTable("payroll_increasementformula");

            entity.HasIndex(e => e.name, "UQ__payroll___72E12F1BBBA07EEB").IsUnique();

            entity.Property(e => e.formula).HasMaxLength(100);
            entity.Property(e => e.name).HasMaxLength(30);
        });

        modelBuilder.Entity<payroll_leaveformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F00DF0F06");

            entity.ToTable("payroll_leaveformula");

            entity.HasIndex(e => e.name, "UQ__payroll___72E12F1B3FE7E822").IsUnique();

            entity.HasIndex(e => e.pay_code_id, "payroll_leaveformula_pay_code_id_63c7b4bd");

            entity.Property(e => e.formula).HasMaxLength(100);
            entity.Property(e => e.name).HasMaxLength(30);

            entity.HasOne(d => d.pay_code).WithMany(p => p.payroll_leaveformulas)
                .HasForeignKey(d => d.pay_code_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_leaveformula_pay_code_id_63c7b4bd_fk_att_paycode_id");
        });

        modelBuilder.Entity<payroll_overtimeformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83FD3C1605B");

            entity.ToTable("payroll_overtimeformula");

            entity.HasIndex(e => e.name, "UQ__payroll___72E12F1BE770EFB4").IsUnique();

            entity.HasIndex(e => e.pay_code_id, "payroll_overtimeformula_pay_code_id_36d2f10e");

            entity.Property(e => e.formula).HasMaxLength(100);
            entity.Property(e => e.name).HasMaxLength(30);

            entity.HasOne(d => d.pay_code).WithMany(p => p.payroll_overtimeformulas)
                .HasForeignKey(d => d.pay_code_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_overtimeformula_pay_code_id_36d2f10e_fk_att_paycode_id");
        });

        modelBuilder.Entity<payroll_payrollpayload>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83FBFDBA211");

            entity.ToTable("payroll_payrollpayload");

            entity.HasIndex(e => e.employee_id, "payroll_payrollpayload_employee_id_bc868f2b");

            entity.Property(e => e.calc_time).HasColumnType("datetime");
            entity.Property(e => e.effective_date).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.payroll_payrollpayloads)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_payrollpayload_employee_id_bc868f2b_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_payrollpayloadpaycode>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F311397FC");

            entity.ToTable("payroll_payrollpayloadpaycode");

            entity.HasIndex(e => e.pay_code_id, "payroll_payrollpayloadpaycode_pay_code_id_c057af1f");

            entity.HasIndex(e => e.payload_id, "payroll_payrollpayloadpaycode_payload_id_f085c4e8");

            entity.HasOne(d => d.pay_code).WithMany(p => p.payroll_payrollpayloadpaycodes)
                .HasForeignKey(d => d.pay_code_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_payrollpayloadpaycode_pay_code_id_c057af1f_fk_att_paycode_id");

            entity.HasOne(d => d.payload).WithMany(p => p.payroll_payrollpayloadpaycodes)
                .HasForeignKey(d => d.payload_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_payrollpayloadpaycode_payload_id_f085c4e8_fk_payroll_payrollpayload_id");
        });

        modelBuilder.Entity<payroll_reimbursement>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F26ABA7CB");

            entity.ToTable("payroll_reimbursement");

            entity.HasIndex(e => e.employee_id, "payroll_reimbursement_employee_id_c4bbde36");

            entity.Property(e => e.rmb_file).HasMaxLength(200);
            entity.Property(e => e.rmb_remark).HasMaxLength(300);
            entity.Property(e => e.rmb_time).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.payroll_reimbursements)
                .HasForeignKey(d => d.employee_id)
                .HasConstraintName("payroll_reimbursement_employee_id_c4bbde36_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_salaryadvance>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F95B5E63B");

            entity.ToTable("payroll_salaryadvance");

            entity.HasIndex(e => e.employee_id, "payroll_salaryadvance_employee_id_2abd43e5");

            entity.Property(e => e.advance_remark).HasMaxLength(300);
            entity.Property(e => e.advance_time).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithMany(p => p.payroll_salaryadvances)
                .HasForeignKey(d => d.employee_id)
                .HasConstraintName("payroll_salaryadvance_employee_id_2abd43e5_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_salarystructure>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F9AE366AD");

            entity.ToTable("payroll_salarystructure");

            entity.HasIndex(e => e.employee_id, "payroll_salarystructure_employee_id_98996e15");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.effective_date).HasColumnType("datetime");
            entity.Property(e => e.salary_remark).HasMaxLength(300);

            entity.HasOne(d => d.employee).WithMany(p => p.payroll_salarystructures)
                .HasForeignKey(d => d.employee_id)
                .HasConstraintName("payroll_salarystructure_employee_id_98996e15_fk_personnel_employee_id");
        });

        modelBuilder.Entity<payroll_salarystructure_deductionformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83FE7D44BE9");

            entity.ToTable("payroll_salarystructure_deductionformula");

            entity.HasIndex(e => e.deductionformula_id, "payroll_salarystructure_deductionformula_deductionformula_id_b174d5b6");

            entity.HasIndex(e => e.salarystructure_id, "payroll_salarystructure_deductionformula_salarystructure_id_5ca7cdb5");

            entity.HasIndex(e => new { e.salarystructure_id, e.deductionformula_id }, "payroll_salarystructure_deductionformula_salarystructure_id_deductionformula_id_794e8449_uniq").IsUnique();

            entity.HasOne(d => d.deductionformula).WithMany(p => p.payroll_salarystructure_deductionformulas)
                .HasForeignKey(d => d.deductionformula_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_deductionformula_deductionformula_id_b174d5b6_fk_payroll_deductionformula_id");

            entity.HasOne(d => d.salarystructure).WithMany(p => p.payroll_salarystructure_deductionformulas)
                .HasForeignKey(d => d.salarystructure_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_deductionformula_salarystructure_id_5ca7cdb5_fk_payroll_salarystructure_id");
        });

        modelBuilder.Entity<payroll_salarystructure_exceptionformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F244AB5D1");

            entity.ToTable("payroll_salarystructure_exceptionformula");

            entity.HasIndex(e => e.exceptionformula_id, "payroll_salarystructure_exceptionformula_exceptionformula_id_8f6dadb3");

            entity.HasIndex(e => e.salarystructure_id, "payroll_salarystructure_exceptionformula_salarystructure_id_3c087208");

            entity.HasIndex(e => new { e.salarystructure_id, e.exceptionformula_id }, "payroll_salarystructure_exceptionformula_salarystructure_id_exceptionformula_id_a5e869ff_uniq").IsUnique();

            entity.HasOne(d => d.exceptionformula).WithMany(p => p.payroll_salarystructure_exceptionformulas)
                .HasForeignKey(d => d.exceptionformula_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_exceptionformula_exceptionformula_id_8f6dadb3_fk_payroll_exceptionformula_id");

            entity.HasOne(d => d.salarystructure).WithMany(p => p.payroll_salarystructure_exceptionformulas)
                .HasForeignKey(d => d.salarystructure_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_exceptionformula_salarystructure_id_3c087208_fk_payroll_salarystructure_id");
        });

        modelBuilder.Entity<payroll_salarystructure_increasementformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F7359F3AC");

            entity.ToTable("payroll_salarystructure_increasementformula");

            entity.HasIndex(e => e.increasementformula_id, "payroll_salarystructure_increasementformula_increasementformula_id_3cd77082");

            entity.HasIndex(e => e.salarystructure_id, "payroll_salarystructure_increasementformula_salarystructure_id_8752401c");

            entity.HasIndex(e => new { e.salarystructure_id, e.increasementformula_id }, "payroll_salarystructure_increasementformula_salarystructure_id_increasementformula_id_749132b3_uniq").IsUnique();

            entity.HasOne(d => d.increasementformula).WithMany(p => p.payroll_salarystructure_increasementformulas)
                .HasForeignKey(d => d.increasementformula_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_increasementformula_increasementformula_id_3cd77082_fk_payroll_increasementformula_id");

            entity.HasOne(d => d.salarystructure).WithMany(p => p.payroll_salarystructure_increasementformulas)
                .HasForeignKey(d => d.salarystructure_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_increasementformula_salarystructure_id_8752401c_fk_payroll_salarystructure_id");
        });

        modelBuilder.Entity<payroll_salarystructure_leaveformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83F4203811D");

            entity.ToTable("payroll_salarystructure_leaveformula");

            entity.HasIndex(e => e.leaveformula_id, "payroll_salarystructure_leaveformula_leaveformula_id_049f9024");

            entity.HasIndex(e => e.salarystructure_id, "payroll_salarystructure_leaveformula_salarystructure_id_cf98fdd7");

            entity.HasIndex(e => new { e.salarystructure_id, e.leaveformula_id }, "payroll_salarystructure_leaveformula_salarystructure_id_leaveformula_id_4efdce30_uniq").IsUnique();

            entity.HasOne(d => d.leaveformula).WithMany(p => p.payroll_salarystructure_leaveformulas)
                .HasForeignKey(d => d.leaveformula_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_leaveformula_leaveformula_id_049f9024_fk_payroll_leaveformula_id");

            entity.HasOne(d => d.salarystructure).WithMany(p => p.payroll_salarystructure_leaveformulas)
                .HasForeignKey(d => d.salarystructure_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_leaveformula_salarystructure_id_cf98fdd7_fk_payroll_salarystructure_id");
        });

        modelBuilder.Entity<payroll_salarystructure_overtimeformula>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__payroll___3213E83FD41F71ED");

            entity.ToTable("payroll_salarystructure_overtimeformula");

            entity.HasIndex(e => e.overtimeformula_id, "payroll_salarystructure_overtimeformula_overtimeformula_id_40ad89ef");

            entity.HasIndex(e => e.salarystructure_id, "payroll_salarystructure_overtimeformula_salarystructure_id_64f75042");

            entity.HasIndex(e => new { e.salarystructure_id, e.overtimeformula_id }, "payroll_salarystructure_overtimeformula_salarystructure_id_overtimeformula_id_0d0a0e81_uniq").IsUnique();

            entity.HasOne(d => d.overtimeformula).WithMany(p => p.payroll_salarystructure_overtimeformulas)
                .HasForeignKey(d => d.overtimeformula_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_overtimeformula_overtimeformula_id_40ad89ef_fk_payroll_overtimeformula_id");

            entity.HasOne(d => d.salarystructure).WithMany(p => p.payroll_salarystructure_overtimeformulas)
                .HasForeignKey(d => d.salarystructure_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payroll_salarystructure_overtimeformula_salarystructure_id_64f75042_fk_payroll_salarystructure_id");
        });

        modelBuilder.Entity<personnel_area>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F702930A3");

            entity.ToTable("personnel_area");

            entity.HasIndex(e => e.company_id, "personnel_area_company_id_59750eb5");

            entity.HasIndex(e => new { e.company_id, e.area_code }, "personnel_area_company_id_area_code_aa39c55c_uniq").IsUnique();

            entity.HasIndex(e => e.parent_area_id, "personnel_area_parent_area_id_39028fda");

            entity.Property(e => e.area_code).HasMaxLength(30);
            entity.Property(e => e.area_name).HasMaxLength(30);

            entity.HasOne(d => d.company).WithMany(p => p.personnel_areas)
                .HasForeignKey(d => d.company_id)
                .HasConstraintName("personnel_area_company_id_59750eb5_fk_personnel_company_id");

            entity.HasOne(d => d.parent_area).WithMany(p => p.Inverseparent_area)
                .HasForeignKey(d => d.parent_area_id)
                .HasConstraintName("personnel_area_parent_area_id_39028fda_fk_personnel_area_id");
        });

        modelBuilder.Entity<personnel_assignareaemployee>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F76866BE3");

            entity.ToTable("personnel_assignareaemployee");

            entity.HasIndex(e => e.area_id, "personnel_assignareaemployee_area_id_6f049d6a");

            entity.HasIndex(e => e.employee_id, "personnel_assignareaemployee_employee_id_a3d4dd25");

            entity.Property(e => e.assigned_time).HasColumnType("datetime");

            entity.HasOne(d => d.area).WithMany(p => p.personnel_assignareaemployees)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_assignareaemployee_area_id_6f049d6a_fk_personnel_area_id");

            entity.HasOne(d => d.employee).WithMany(p => p.personnel_assignareaemployees)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_assignareaemployee_employee_id_a3d4dd25_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_certification>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83FC9B9ACC4");

            entity.ToTable("personnel_certification");

            entity.HasIndex(e => e.cert_name, "UQ__personne__1B8BDCA7331EFC4D").IsUnique();

            entity.HasIndex(e => e.cert_code, "UQ__personne__34D3AE57273AF928").IsUnique();

            entity.Property(e => e.cert_code).HasMaxLength(20);
            entity.Property(e => e.cert_name).HasMaxLength(50);
        });

        modelBuilder.Entity<personnel_company>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F9B6788A0");

            entity.ToTable("personnel_company");

            entity.HasIndex(e => e.company_code, "UQ__personne__F4E508EA4B6A5395").IsUnique();

            entity.Property(e => e.company_code).HasMaxLength(50);
            entity.Property(e => e.company_name).HasMaxLength(100);
        });

        modelBuilder.Entity<personnel_department>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F83B5FF74");

            entity.ToTable("personnel_department");

            entity.HasIndex(e => e.company_id, "personnel_department_company_id_00867fd8");

            entity.HasIndex(e => new { e.company_id, e.dept_code }, "personnel_department_company_id_dept_code_dfa8fff7_uniq").IsUnique();

            entity.HasIndex(e => e.dept_manager_id, "personnel_department_dept_manager_id_c5124a7d");

            entity.HasIndex(e => e.parent_dept_id, "personnel_department_parent_dept_id_d0b44024");

            entity.Property(e => e.dept_code).HasMaxLength(50);
            entity.Property(e => e.dept_name).HasMaxLength(100);

            entity.HasOne(d => d.company).WithMany(p => p.personnel_departments)
                .HasForeignKey(d => d.company_id)
                .HasConstraintName("personnel_department_company_id_00867fd8_fk_personnel_company_id");

            entity.HasOne(d => d.dept_manager).WithMany(p => p.personnel_departments)
                .HasForeignKey(d => d.dept_manager_id)
                .HasConstraintName("personnel_department_dept_manager_id_c5124a7d_fk_personnel_employee_id");

            entity.HasOne(d => d.parent_dept).WithMany(p => p.Inverseparent_dept)
                .HasForeignKey(d => d.parent_dept_id)
                .HasConstraintName("personnel_department_parent_dept_id_d0b44024_fk_personnel_department_id");
        });

        modelBuilder.Entity<personnel_employee>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F6F406DC8");

            entity.ToTable("personnel_employee");

            entity.HasIndex(e => e.company_id, "personnel_employee_company_id_95b3fd72");

            entity.HasIndex(e => new { e.company_id, e.emp_code }, "personnel_employee_company_id_emp_code_81daa575_uniq").IsUnique();

            entity.HasIndex(e => e.department_id, "personnel_employee_department_id_068bbd08");

            entity.HasIndex(e => e.position_id, "personnel_employee_position_id_c9321343");

            entity.HasIndex(e => e.superior_id, "personnel_employee_superior_id_ad6e1c47");

            entity.Property(e => e.acc_group).HasMaxLength(5);
            entity.Property(e => e.acc_timezone).HasMaxLength(20);
            entity.Property(e => e.address).HasMaxLength(200);
            entity.Property(e => e.birthday).HasColumnType("datetime");
            entity.Property(e => e.card_no).HasMaxLength(20);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.city).HasMaxLength(20);
            entity.Property(e => e.contact_tel).HasMaxLength(20);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.device_password).HasMaxLength(20);
            entity.Property(e => e.driver_license_automobile).HasMaxLength(30);
            entity.Property(e => e.driver_license_motorcycle).HasMaxLength(30);
            entity.Property(e => e.email).HasMaxLength(50);
            entity.Property(e => e.emp_code).HasMaxLength(20);
            entity.Property(e => e.enroll_sn).HasMaxLength(20);
            entity.Property(e => e.first_name).HasMaxLength(100);
            entity.Property(e => e.gender).HasMaxLength(1);
            entity.Property(e => e.hire_date).HasColumnType("datetime");
            entity.Property(e => e.last_login).HasColumnType("datetime");
            entity.Property(e => e.last_name).HasMaxLength(50);
            entity.Property(e => e.login_ip).HasMaxLength(32);
            entity.Property(e => e.mobile).HasMaxLength(20);
            entity.Property(e => e.national).HasMaxLength(50);
            entity.Property(e => e.nickname).HasMaxLength(50);
            entity.Property(e => e.office_tel).HasMaxLength(20);
            entity.Property(e => e.passport).HasMaxLength(30);
            entity.Property(e => e.photo).HasMaxLength(200);
            entity.Property(e => e.postcode).HasMaxLength(10);
            entity.Property(e => e.religion).HasMaxLength(20);
            entity.Property(e => e.self_password).HasMaxLength(128);
            entity.Property(e => e.session_key).HasMaxLength(32);
            entity.Property(e => e.ssn).HasMaxLength(20);
            entity.Property(e => e.title).HasMaxLength(20);
            entity.Property(e => e.update_time).HasColumnType("datetime");

            entity.HasOne(d => d.company).WithMany(p => p.personnel_employees)
                .HasForeignKey(d => d.company_id)
                .HasConstraintName("personnel_employee_company_id_95b3fd72_fk_personnel_company_id");

            entity.HasOne(d => d.department).WithMany(p => p.personnel_employees)
                .HasForeignKey(d => d.department_id)
                .HasConstraintName("personnel_employee_department_id_068bbd08_fk_personnel_department_id");

            entity.HasOne(d => d.position).WithMany(p => p.personnel_employees)
                .HasForeignKey(d => d.position_id)
                .HasConstraintName("personnel_employee_position_id_c9321343_fk_personnel_position_id");

            entity.HasOne(d => d.superior).WithMany(p => p.Inversesuperior)
                .HasForeignKey(d => d.superior_id)
                .HasConstraintName("personnel_employee_superior_id_ad6e1c47_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_employee_area>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83FFE9CEFC5");

            entity.ToTable("personnel_employee_area");

            entity.HasIndex(e => e.area_id, "personnel_employee_area_area_id_64c21925");

            entity.HasIndex(e => e.employee_id, "personnel_employee_area_employee_id_8e5cec21");

            entity.HasIndex(e => new { e.employee_id, e.area_id }, "personnel_employee_area_employee_id_area_id_00b3d777_uniq").IsUnique();

            entity.HasOne(d => d.area).WithMany(p => p.personnel_employee_areas)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employee_area_area_id_64c21925_fk_personnel_area_id");

            entity.HasOne(d => d.employee).WithMany(p => p.personnel_employee_areas)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employee_area_employee_id_8e5cec21_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_employee_flow_role>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83FA6FF5C15");

            entity.ToTable("personnel_employee_flow_role");

            entity.HasIndex(e => e.employee_id, "personnel_employee_flow_role_employee_id_c27f8a56");

            entity.HasIndex(e => new { e.employee_id, e.workflowrole_id }, "personnel_employee_flow_role_employee_id_workflowrole_id_46b0e5e0_uniq").IsUnique();

            entity.HasIndex(e => e.workflowrole_id, "personnel_employee_flow_role_workflowrole_id_4704db32");

            entity.HasOne(d => d.employee).WithMany(p => p.personnel_employee_flow_roles)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employee_flow_role_employee_id_c27f8a56_fk_personnel_employee_id");

            entity.HasOne(d => d.workflowrole).WithMany(p => p.personnel_employee_flow_roles)
                .HasForeignKey(d => d.workflowrole_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employee_flow_role_workflowrole_id_4704db32_fk_workflow_workflowrole_id");
        });

        modelBuilder.Entity<personnel_employeecalendar>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F2BDEA0C4");

            entity.ToTable("personnel_employeecalendar");

            entity.HasIndex(e => e.employee_id, "personnel_employeecalendar_employee_id_165e0779");

            entity.HasIndex(e => new { e.employee_id, e.calendar }, "personnel_employeecalendar_employee_id_calendar_10f7278d_uniq").IsUnique();

            entity.Property(e => e.calendar).HasMaxLength(100);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);

            entity.HasOne(d => d.employee).WithMany(p => p.personnel_employeecalendars)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeecalendar_employee_id_165e0779_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_employeecertification>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83FF793560C");

            entity.ToTable("personnel_employeecertification");

            entity.HasIndex(e => e.certification_id, "personnel_employeecertification_certification_id_faabed40");

            entity.HasIndex(e => e.employee_id, "personnel_employeecertification_employee_id_b7bd3867");

            entity.HasIndex(e => new { e.employee_id, e.certification_id }, "personnel_employeecertification_employee_id_certification_id_7bcf4c7d_uniq").IsUnique();

            entity.Property(e => e.certification_code).HasMaxLength(20);
            entity.Property(e => e.expire_on).HasColumnType("datetime");
            entity.Property(e => e.file).HasMaxLength(200);
            entity.Property(e => e.file_name).HasMaxLength(200);

            entity.HasOne(d => d.certification).WithMany(p => p.personnel_employeecertifications)
                .HasForeignKey(d => d.certification_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeecertification_certification_id_faabed40_fk_personnel_certification_id");

            entity.HasOne(d => d.employee).WithMany(p => p.personnel_employeecertifications)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeecertification_employee_id_b7bd3867_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_employeecustomattribute>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83FA9944455");

            entity.ToTable("personnel_employeecustomattribute");

            entity.HasIndex(e => e.attr_name, "UQ__personne__A0FDB96964CC3AFD").IsUnique();

            entity.Property(e => e.attr_name).HasMaxLength(50);
            entity.Property(e => e.attr_value).HasMaxLength(200);
        });

        modelBuilder.Entity<personnel_employeeextrainfo>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83FDA2E67B1");

            entity.ToTable("personnel_employeeextrainfo");

            entity.HasIndex(e => e.employee_id, "UQ__personne__C52E0BA993C472B2").IsUnique();

            entity.HasOne(d => d.employee).WithOne(p => p.personnel_employeeextrainfo)
                .HasForeignKey<personnel_employeeextrainfo>(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeeextrainfo_employee_id_41e2b04d_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_employeeprofile>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F16EABD7F");

            entity.ToTable("personnel_employeeprofile");

            entity.HasIndex(e => e.emp_id, "UQ__personne__1299A8604BD95367").IsUnique();

            entity.Property(e => e.pwd_update_time).HasColumnType("datetime");

            entity.HasOne(d => d.emp).WithOne(p => p.personnel_employeeprofile)
                .HasForeignKey<personnel_employeeprofile>(d => d.emp_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employeeprofile_emp_id_3a69c313_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_employment>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F38D39A18");

            entity.ToTable("personnel_employment");

            entity.HasIndex(e => e.employee_id, "UQ__personne__C52E0BA98E0BFD53").IsUnique();

            entity.Property(e => e.active_time).HasColumnType("datetime");
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.inactive_time).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithOne(p => p.personnel_employment)
                .HasForeignKey<personnel_employment>(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_employment_employee_id_f797c7d9_fk_personnel_employee_id");
        });

        modelBuilder.Entity<personnel_position>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F93C2A322");

            entity.ToTable("personnel_position");

            entity.HasIndex(e => e.company_id, "personnel_position_company_id_f06c5d2a");

            entity.HasIndex(e => new { e.company_id, e.position_code }, "personnel_position_company_id_position_code_4708726e_uniq").IsUnique();

            entity.HasIndex(e => e.parent_position_id, "personnel_position_parent_position_id_a496a36b");

            entity.Property(e => e.position_code).HasMaxLength(50);
            entity.Property(e => e.position_name).HasMaxLength(100);

            entity.HasOne(d => d.company).WithMany(p => p.personnel_positions)
                .HasForeignKey(d => d.company_id)
                .HasConstraintName("personnel_position_company_id_f06c5d2a_fk_personnel_company_id");

            entity.HasOne(d => d.parent_position).WithMany(p => p.Inverseparent_position)
                .HasForeignKey(d => d.parent_position_id)
                .HasConstraintName("personnel_position_parent_position_id_a496a36b_fk_personnel_position_id");
        });

        modelBuilder.Entity<personnel_resign>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__personne__3213E83F92EC79B7");

            entity.ToTable("personnel_resign");

            entity.HasIndex(e => e.employee_id, "UQ__personne__C52E0BA9DBB933AC").IsUnique();

            entity.Property(e => e.reason).HasMaxLength(200);
            entity.Property(e => e.resign_date).HasColumnType("datetime");

            entity.HasOne(d => d.employee).WithOne(p => p.personnel_resign)
                .HasForeignKey<personnel_resign>(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("personnel_resign_employee_id_dd9b7e08_fk_personnel_employee_id");
        });

        modelBuilder.Entity<rest_framework_tracking_apirequestlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__rest_fra__3213E83F0525C20C");

            entity.ToTable("rest_framework_tracking_apirequestlog");

            entity.HasIndex(e => e.path, "rest_framework_tracking_apirequestlog_path_fe81f91b");

            entity.HasIndex(e => e.requested_at, "rest_framework_tracking_apirequestlog_requested_at_b6f1c2f2");

            entity.HasIndex(e => e.status_code, "rest_framework_tracking_apirequestlog_status_code_3c9e2003");

            entity.HasIndex(e => e.user_id, "rest_framework_tracking_apirequestlog_user_id_671b70b7");

            entity.HasIndex(e => e.view, "rest_framework_tracking_apirequestlog_view_5bd1e407");

            entity.HasIndex(e => e.view_method, "rest_framework_tracking_apirequestlog_view_method_dd790881_idx");

            entity.Property(e => e.host).HasMaxLength(200);
            entity.Property(e => e.method).HasMaxLength(10);
            entity.Property(e => e.path).HasMaxLength(200);
            entity.Property(e => e.remote_addr).HasMaxLength(39);
            entity.Property(e => e.requested_at).HasColumnType("datetime");
            entity.Property(e => e.username_persistent).HasMaxLength(200);
            entity.Property(e => e.view).HasMaxLength(200);
            entity.Property(e => e.view_method).HasMaxLength(200);

            entity.HasOne(d => d.user).WithMany(p => p.rest_framework_tracking_apirequestlogs)
                .HasForeignKey(d => d.user_id)
                .HasConstraintName("rest_framework_tracking_apirequestlog_user_id_671b70b7_fk_auth_user_id");
        });

        modelBuilder.Entity<staff_stafftoken>(entity =>
        {
            entity.HasKey(e => e.key).HasName("PK__staff_st__DFD83CAE2FED8D30");

            entity.ToTable("staff_stafftoken");

            entity.HasIndex(e => e.user_id, "UQ__staff_st__B9BE370E63CCB545").IsUnique();

            entity.Property(e => e.key).HasMaxLength(40);
            entity.Property(e => e.created).HasColumnType("datetime");

            entity.HasOne(d => d.user).WithOne(p => p.staff_stafftoken)
                .HasForeignKey<staff_stafftoken>(d => d.user_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("staff_stafftoken_user_id_39c937fa_fk_personnel_employee_id");
        });

        modelBuilder.Entity<sync_area>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__sync_are__3213E83FB3457F98");

            entity.ToTable("sync_area");

            entity.HasIndex(e => new { e.area_code, e.area_name }, "sync_area_area_code_area_name_200046d1_uniq").IsUnique();

            entity.Property(e => e.area_code).HasMaxLength(30);
            entity.Property(e => e.area_name).HasMaxLength(30);
            entity.Property(e => e.parent_area_code).HasMaxLength(30);
            entity.Property(e => e.post_time).HasColumnType("datetime");
            entity.Property(e => e.sync_ret).HasMaxLength(200);
            entity.Property(e => e.update_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<sync_department>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__sync_dep__3213E83FFB4501DA");

            entity.ToTable("sync_department");

            entity.HasIndex(e => new { e.dept_code, e.dept_name }, "sync_department_dept_code_dept_name_93923213_uniq").IsUnique();

            entity.Property(e => e.dept_code).HasMaxLength(50);
            entity.Property(e => e.dept_name).HasMaxLength(100);
            entity.Property(e => e.parent_dept_code).HasMaxLength(50);
            entity.Property(e => e.post_time).HasColumnType("datetime");
            entity.Property(e => e.sync_ret).HasMaxLength(200);
            entity.Property(e => e.update_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<sync_employee>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__sync_emp__3213E83FBDC915E8");

            entity.ToTable("sync_employee");

            entity.HasIndex(e => e.emp_code, "sync_employee_emp_code_521bf06d_uniq").IsUnique();

            entity.Property(e => e.area_code).HasMaxLength(30);
            entity.Property(e => e.area_name).HasMaxLength(30);
            entity.Property(e => e.birthday).HasColumnType("datetime");
            entity.Property(e => e.card_no).HasMaxLength(20);
            entity.Property(e => e.dept_code).HasMaxLength(50);
            entity.Property(e => e.dept_name).HasMaxLength(100);
            entity.Property(e => e.email).HasMaxLength(100);
            entity.Property(e => e.emp_code).HasMaxLength(20);
            entity.Property(e => e.first_name).HasMaxLength(100);
            entity.Property(e => e.gender).HasMaxLength(2);
            entity.Property(e => e.hire_date).HasColumnType("datetime");
            entity.Property(e => e.job_code).HasMaxLength(50);
            entity.Property(e => e.job_name).HasMaxLength(100);
            entity.Property(e => e.last_name).HasMaxLength(50);
            entity.Property(e => e.post_time).HasColumnType("datetime");
            entity.Property(e => e.sync_ret).HasMaxLength(200);
            entity.Property(e => e.update_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<sync_job>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__sync_job__3213E83FD051ABBB");

            entity.ToTable("sync_job");

            entity.HasIndex(e => new { e.job_code, e.job_name }, "sync_job_job_code_job_name_4ec5619e_uniq").IsUnique();

            entity.Property(e => e.job_code).HasMaxLength(50);
            entity.Property(e => e.job_name).HasMaxLength(100);
            entity.Property(e => e.post_time).HasColumnType("datetime");
            entity.Property(e => e.sync_ret).HasMaxLength(200);
            entity.Property(e => e.update_time).HasColumnType("datetime");
        });

        modelBuilder.Entity<visitor_reason>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83F69C368C1");

            entity.ToTable("visitor_reason");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.visit_reason).HasMaxLength(100);
        });

        modelBuilder.Entity<visitor_reservation>(entity =>
        {
            entity.HasKey(e => e.workflowinstance_ptr_id).HasName("PK__visitor___2F050E153093B5F4");

            entity.ToTable("visitor_reservation");

            entity.HasIndex(e => e.cert_type_id, "visitor_reservation_cert_type_id_4f047f2a");

            entity.HasIndex(e => e.visit_department_id, "visitor_reservation_visit_department_id_2d293e10");

            entity.HasIndex(e => e.visit_reason_id, "visitor_reservation_visit_reason_id_c9ac83ac");

            entity.Property(e => e.workflowinstance_ptr_id).ValueGeneratedNever();
            entity.Property(e => e.apply_time).HasColumnType("datetime");
            entity.Property(e => e.cert_no).HasMaxLength(50);
            entity.Property(e => e.company).HasMaxLength(100);
            entity.Property(e => e.email).HasMaxLength(50);
            entity.Property(e => e.gender).HasMaxLength(1);
            entity.Property(e => e.update_time).HasColumnType("datetime");
            entity.Property(e => e.vis_first_name).HasMaxLength(25);
            entity.Property(e => e.vis_last_name).HasMaxLength(25);
            entity.Property(e => e.visit_date).HasColumnType("datetime");

            entity.HasOne(d => d.cert_type).WithMany(p => p.visitor_reservations)
                .HasForeignKey(d => d.cert_type_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_reservation_cert_type_id_4f047f2a_fk_personnel_certification_id");

            entity.HasOne(d => d.visit_department).WithMany(p => p.visitor_reservations)
                .HasForeignKey(d => d.visit_department_id)
                .HasConstraintName("visitor_reservation_visit_department_id_2d293e10_fk_personnel_department_id");

            entity.HasOne(d => d.visit_reason).WithMany(p => p.visitor_reservations)
                .HasForeignKey(d => d.visit_reason_id)
                .HasConstraintName("visitor_reservation_visit_reason_id_c9ac83ac_fk_visitor_reason_id");

            entity.HasOne(d => d.workflowinstance_ptr).WithOne(p => p.visitor_reservation)
                .HasForeignKey<visitor_reservation>(d => d.workflowinstance_ptr_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_reservation_workflowinstance_ptr_id_3787bcd6_fk_workflow_workflowinstance_id");
        });

        modelBuilder.Entity<visitor_visitor>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83F0EB5C26D");

            entity.ToTable("visitor_visitor");

            entity.HasIndex(e => e.visitor_code, "UQ__visitor___8C752E087E9DCAFA").IsUnique();

            entity.HasIndex(e => e.cert_type_id, "visitor_visitor_cert_type_id_f62ea604");

            entity.HasIndex(e => e.visit_department_id, "visitor_visitor_visit_department_id_f7dbdcb4");

            entity.HasIndex(e => e.visit_reason_id, "visitor_visitor_visit_reason_id_4b9a2d23");

            entity.HasIndex(e => e.visited_id, "visitor_visitor_visited_id_8043a7ea");

            entity.Property(e => e.card_no).HasMaxLength(20);
            entity.Property(e => e.cert_no).HasMaxLength(50);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.company).HasMaxLength(100);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.email).HasMaxLength(50);
            entity.Property(e => e.end_time).HasColumnType("datetime");
            entity.Property(e => e.entry_carrying_goods).HasMaxLength(200);
            entity.Property(e => e.exit_carrying_goods).HasMaxLength(200);
            entity.Property(e => e.exit_time).HasColumnType("datetime");
            entity.Property(e => e.first_name).HasMaxLength(25);
            entity.Property(e => e.gender).HasMaxLength(1);
            entity.Property(e => e.last_name).HasMaxLength(25);
            entity.Property(e => e.mobile).HasMaxLength(20);
            entity.Property(e => e.password).HasMaxLength(20);
            entity.Property(e => e.photo).HasMaxLength(200);
            entity.Property(e => e.remark).HasMaxLength(200);
            entity.Property(e => e.ssn).HasMaxLength(20);
            entity.Property(e => e.start_time).HasColumnType("datetime");
            entity.Property(e => e.update_time).HasColumnType("datetime");
            entity.Property(e => e.visitor_code).HasMaxLength(20);

            entity.HasOne(d => d.cert_type).WithMany(p => p.visitor_visitors)
                .HasForeignKey(d => d.cert_type_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_cert_type_id_f62ea604_fk_personnel_certification_id");

            entity.HasOne(d => d.visit_department).WithMany(p => p.visitor_visitors)
                .HasForeignKey(d => d.visit_department_id)
                .HasConstraintName("visitor_visitor_visit_department_id_f7dbdcb4_fk_personnel_department_id");

            entity.HasOne(d => d.visit_reason).WithMany(p => p.visitor_visitors)
                .HasForeignKey(d => d.visit_reason_id)
                .HasConstraintName("visitor_visitor_visit_reason_id_4b9a2d23_fk_visitor_reason_id");

            entity.HasOne(d => d.visited).WithMany(p => p.visitor_visitors)
                .HasForeignKey(d => d.visited_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_visited_id_8043a7ea_fk_personnel_employee_id");
        });

        modelBuilder.Entity<visitor_visitor_acc_group>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83FF93EB829");

            entity.HasIndex(e => e.accgroups_id, "visitor_visitor_acc_groups_accgroups_id_b1487149");

            entity.HasIndex(e => e.visitor_id, "visitor_visitor_acc_groups_visitor_id_8ce09562");

            entity.HasIndex(e => new { e.visitor_id, e.accgroups_id }, "visitor_visitor_acc_groups_visitor_id_accgroups_id_bb522609_uniq").IsUnique();

            entity.HasOne(d => d.accgroups).WithMany(p => p.visitor_visitor_acc_groups)
                .HasForeignKey(d => d.accgroups_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_acc_groups_accgroups_id_b1487149_fk_acc_accgroups_id");

            entity.HasOne(d => d.visitor).WithMany(p => p.visitor_visitor_acc_groups)
                .HasForeignKey(d => d.visitor_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_acc_groups_visitor_id_8ce09562_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<visitor_visitor_area>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83F73FBF0DE");

            entity.ToTable("visitor_visitor_area");

            entity.HasIndex(e => e.area_id, "visitor_visitor_area_area_id_b402c047");

            entity.HasIndex(e => e.visitor_id, "visitor_visitor_area_visitor_id_98d7ed05");

            entity.HasIndex(e => new { e.visitor_id, e.area_id }, "visitor_visitor_area_visitor_id_area_id_27d158cc_uniq").IsUnique();

            entity.HasOne(d => d.area).WithMany(p => p.visitor_visitor_areas)
                .HasForeignKey(d => d.area_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_area_area_id_b402c047_fk_personnel_area_id");

            entity.HasOne(d => d.visitor).WithMany(p => p.visitor_visitor_areas)
                .HasForeignKey(d => d.visitor_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitor_area_visitor_id_98d7ed05_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<visitor_visitorbiodatum>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83F718A1ADA");

            entity.HasIndex(e => e.visitor_id, "visitor_visitorbiodata_visitor_id_b944ed37");

            entity.HasIndex(e => new { e.visitor_id, e.bio_no, e.bio_index, e.bio_type, e.bio_format, e.major_ver }, "visitor_visitorbiodata_visitor_id_bio_no_bio_index_bio_type_bio_format_major_ver_e5d598fb_uniq").IsUnique();

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.major_ver).HasMaxLength(30);
            entity.Property(e => e.minor_ver).HasMaxLength(30);
            entity.Property(e => e.sn).HasMaxLength(50);
            entity.Property(e => e.update_time).HasColumnType("datetime");

            entity.HasOne(d => d.visitor).WithMany(p => p.visitor_visitorbiodata)
                .HasForeignKey(d => d.visitor_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitorbiodata_visitor_id_b944ed37_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<visitor_visitorbiophoto>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83F3A5CFA8C");

            entity.ToTable("visitor_visitorbiophoto");

            entity.HasIndex(e => e.visitor_id, "visitor_visitorbiophoto_visitor_id_9816daf7");

            entity.Property(e => e.approval_photo).HasMaxLength(100);
            entity.Property(e => e.approval_time).HasColumnType("datetime");
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.email).HasMaxLength(254);
            entity.Property(e => e.enroll_sn).HasMaxLength(50);
            entity.Property(e => e.first_name).HasMaxLength(100);
            entity.Property(e => e.last_name).HasMaxLength(50);
            entity.Property(e => e.register_photo).HasMaxLength(100);
            entity.Property(e => e.register_time).HasColumnType("datetime");
            entity.Property(e => e.remark).HasMaxLength(100);

            entity.HasOne(d => d.visitor).WithMany(p => p.visitor_visitorbiophotos)
                .HasForeignKey(d => d.visitor_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitorbiophoto_visitor_id_9816daf7_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<visitor_visitorconfig>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83FAB2BF9A4");

            entity.ToTable("visitor_visitorconfig");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.code_prefix).HasMaxLength(5);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
        });

        modelBuilder.Entity<visitor_visitorlog>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83FBAC6E6D6");

            entity.ToTable("visitor_visitorlog");

            entity.HasIndex(e => e.visitor_id, "visitor_visitorlog_visitor_id_ebaafde1");

            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);

            entity.HasOne(d => d.visitor).WithMany(p => p.visitor_visitorlogs)
                .HasForeignKey(d => d.visitor_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("visitor_visitorlog_visitor_id_ebaafde1_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<visitor_visitortransaction>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__visitor___3213E83F0798A5D8");

            entity.ToTable("visitor_visitortransaction");

            entity.HasIndex(e => e.terminal_id, "visitor_visitortransaction_terminal_id_7527ef69");

            entity.HasIndex(e => new { e.visitor_code, e.punch_time }, "visitor_visitortransaction_visitor_code_punch_time_2b871513_uniq").IsUnique();

            entity.HasIndex(e => e.visitor_id, "visitor_visitortransaction_visitor_id_0ee95624");

            entity.Property(e => e.area).HasMaxLength(30);
            entity.Property(e => e.change_time).HasColumnType("datetime");
            entity.Property(e => e.change_user).HasMaxLength(150);
            entity.Property(e => e.create_time).HasColumnType("datetime");
            entity.Property(e => e.create_user).HasMaxLength(150);
            entity.Property(e => e.punch_state).HasMaxLength(5);
            entity.Property(e => e.punch_time).HasColumnType("datetime");
            entity.Property(e => e.temperature).HasColumnType("numeric(4, 1)");
            entity.Property(e => e.terminal_alias).HasMaxLength(50);
            entity.Property(e => e.terminal_sn).HasMaxLength(50);
            entity.Property(e => e.upload_time).HasColumnType("datetime");
            entity.Property(e => e.visitor_code).HasMaxLength(50);

            entity.HasOne(d => d.terminal).WithMany(p => p.visitor_visitortransactions)
                .HasForeignKey(d => d.terminal_id)
                .HasConstraintName("visitor_visitortransaction_terminal_id_7527ef69_fk_iclock_terminal_id");

            entity.HasOne(d => d.visitor).WithMany(p => p.visitor_visitortransactions)
                .HasForeignKey(d => d.visitor_id)
                .HasConstraintName("visitor_visitortransaction_visitor_id_0ee95624_fk_visitor_visitor_id");
        });

        modelBuilder.Entity<workflow_nodeinstance>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83F1E3CE5E2");

            entity.ToTable("workflow_nodeinstance");

            entity.HasIndex(e => e.approver_employee_id, "workflow_nodeinstance_approver_employee_id_d36cd45d");

            entity.HasIndex(e => e.workflow_instance_id, "workflow_nodeinstance_workflow_instance_id_afe84fe4");

            entity.HasIndex(e => e.workflow_node_id, "workflow_nodeinstance_workflow_node_id_166f36c4");

            entity.Property(e => e.approval_remark).HasMaxLength(255);
            entity.Property(e => e.approval_time).HasColumnType("datetime");
            entity.Property(e => e.node_name).HasMaxLength(30);

            entity.HasOne(d => d.approver_employee).WithMany(p => p.workflow_nodeinstances)
                .HasForeignKey(d => d.approver_employee_id)
                .HasConstraintName("workflow_nodeinstance_approver_employee_id_d36cd45d_fk_personnel_employee_id");

            entity.HasOne(d => d.workflow_instance).WithMany(p => p.workflow_nodeinstances)
                .HasForeignKey(d => d.workflow_instance_id)
                .HasConstraintName("workflow_nodeinstance_workflow_instance_id_afe84fe4_fk_workflow_workflowinstance_id");

            entity.HasOne(d => d.workflow_node).WithMany(p => p.workflow_nodeinstances)
                .HasForeignKey(d => d.workflow_node_id)
                .HasConstraintName("workflow_nodeinstance_workflow_node_id_166f36c4_fk_workflow_workflownode_id");
        });

        modelBuilder.Entity<workflow_workflowengine>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83FDBB68F56");

            entity.ToTable("workflow_workflowengine");

            entity.HasIndex(e => e.workflow_code, "UQ__workflow__12BE0D46CDFE28EE").IsUnique();

            entity.HasIndex(e => e.applicant_position_id, "workflow_workflowengine_applicant_position_id_8a65e03a");

            entity.HasIndex(e => e.content_type_id, "workflow_workflowengine_content_type_id_f7345c20");

            entity.HasIndex(e => e.departments_id, "workflow_workflowengine_departments_id_0f06d4c7");

            entity.Property(e => e.description).HasMaxLength(50);
            entity.Property(e => e.end_date).HasColumnType("datetime");
            entity.Property(e => e.start_date).HasColumnType("datetime");
            entity.Property(e => e.workflow_code).HasMaxLength(50);
            entity.Property(e => e.workflow_name).HasMaxLength(50);

            entity.HasOne(d => d.applicant_position).WithMany(p => p.workflow_workflowengines)
                .HasForeignKey(d => d.applicant_position_id)
                .HasConstraintName("workflow_workflowengine_applicant_position_id_8a65e03a_fk_personnel_position_id");

            entity.HasOne(d => d.content_type).WithMany(p => p.workflow_workflowengines)
                .HasForeignKey(d => d.content_type_id)
                .HasConstraintName("workflow_workflowengine_content_type_id_f7345c20_fk_django_content_type_id");

            entity.HasOne(d => d.departments).WithMany(p => p.workflow_workflowengines)
                .HasForeignKey(d => d.departments_id)
                .HasConstraintName("workflow_workflowengine_departments_id_0f06d4c7_fk_personnel_department_id");
        });

        modelBuilder.Entity<workflow_workflowengine_employee>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83F4CAF9BE6");

            entity.ToTable("workflow_workflowengine_employee");

            entity.HasIndex(e => e.employee_id, "workflow_workflowengine_employee_employee_id_803a409e");

            entity.HasIndex(e => e.workflowengine_id, "workflow_workflowengine_employee_workflowengine_id_6ebcc5f2");

            entity.HasIndex(e => new { e.workflowengine_id, e.employee_id }, "workflow_workflowengine_employee_workflowengine_id_employee_id_8128deb2_uniq").IsUnique();

            entity.HasOne(d => d.employee).WithMany(p => p.workflow_workflowengine_employees)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflowengine_employee_employee_id_803a409e_fk_personnel_employee_id");

            entity.HasOne(d => d.workflowengine).WithMany(p => p.workflow_workflowengine_employees)
                .HasForeignKey(d => d.workflowengine_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflowengine_employee_workflowengine_id_6ebcc5f2_fk_workflow_workflowengine_id");
        });

        modelBuilder.Entity<workflow_workflowinstance>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83FF2E66249");

            entity.ToTable("workflow_workflowinstance");

            entity.HasIndex(e => e.employee_id, "workflow_workflowinstance_employee_id_c7cff08e");

            entity.HasIndex(e => e.workflow_engine_id, "workflow_workflowinstance_workflow_engine_id_1e6ac40f");

            entity.Property(e => e.approval_time).HasColumnType("datetime");
            entity.Property(e => e.approver).HasMaxLength(30);

            entity.HasOne(d => d.employee).WithMany(p => p.workflow_workflowinstances)
                .HasForeignKey(d => d.employee_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflowinstance_employee_id_c7cff08e_fk_personnel_employee_id");

            entity.HasOne(d => d.workflow_engine).WithMany(p => p.workflow_workflowinstances)
                .HasForeignKey(d => d.workflow_engine_id)
                .HasConstraintName("workflow_workflowinstance_workflow_engine_id_1e6ac40f_fk_workflow_workflowengine_id");
        });

        modelBuilder.Entity<workflow_workflownode>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83F48B0A80A");

            entity.ToTable("workflow_workflownode");

            entity.HasIndex(e => e.workflow_engine_id, "workflow_workflownode_workflow_engine_id_04c8f470");

            entity.Property(e => e.node_name).HasMaxLength(30);

            entity.HasOne(d => d.workflow_engine).WithMany(p => p.workflow_workflownodes)
                .HasForeignKey(d => d.workflow_engine_id)
                .HasConstraintName("workflow_workflownode_workflow_engine_id_04c8f470_fk_workflow_workflowengine_id");
        });

        modelBuilder.Entity<workflow_workflownode_approver>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83F69FE0B97");

            entity.ToTable("workflow_workflownode_approver");

            entity.HasIndex(e => e.workflownode_id, "workflow_workflownode_approver_workflownode_id_d814c941");

            entity.HasIndex(e => new { e.workflownode_id, e.workflowrole_id }, "workflow_workflownode_approver_workflownode_id_workflowrole_id_7543ba37_uniq").IsUnique();

            entity.HasIndex(e => e.workflowrole_id, "workflow_workflownode_approver_workflowrole_id_c8e00d42");

            entity.HasOne(d => d.workflownode).WithMany(p => p.workflow_workflownode_approvers)
                .HasForeignKey(d => d.workflownode_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownode_approver_workflownode_id_d814c941_fk_workflow_workflownode_id");

            entity.HasOne(d => d.workflowrole).WithMany(p => p.workflow_workflownode_approvers)
                .HasForeignKey(d => d.workflowrole_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownode_approver_workflowrole_id_c8e00d42_fk_workflow_workflowrole_id");
        });

        modelBuilder.Entity<workflow_workflownode_notifier>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83FDAFA86CF");

            entity.ToTable("workflow_workflownode_notifier");

            entity.HasIndex(e => e.workflownode_id, "workflow_workflownode_notifier_workflownode_id_57298016");

            entity.HasIndex(e => new { e.workflownode_id, e.workflowrole_id }, "workflow_workflownode_notifier_workflownode_id_workflowrole_id_cac02b37_uniq").IsUnique();

            entity.HasIndex(e => e.workflowrole_id, "workflow_workflownode_notifier_workflowrole_id_73de7fc2");

            entity.HasOne(d => d.workflownode).WithMany(p => p.workflow_workflownode_notifiers)
                .HasForeignKey(d => d.workflownode_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownode_notifier_workflownode_id_57298016_fk_workflow_workflownode_id");

            entity.HasOne(d => d.workflowrole).WithMany(p => p.workflow_workflownode_notifiers)
                .HasForeignKey(d => d.workflowrole_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("workflow_workflownode_notifier_workflowrole_id_73de7fc2_fk_workflow_workflowrole_id");
        });

        modelBuilder.Entity<workflow_workflowrole>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__workflow__3213E83F92922045");

            entity.ToTable("workflow_workflowrole");

            entity.HasIndex(e => e.role_name, "UQ__workflow__783254B1F570EE36").IsUnique();

            entity.HasIndex(e => e.role_code, "UQ__workflow__BAE6307595F3A907").IsUnique();

            entity.Property(e => e.description).HasMaxLength(200);
            entity.Property(e => e.role_code).HasMaxLength(30);
            entity.Property(e => e.role_name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
