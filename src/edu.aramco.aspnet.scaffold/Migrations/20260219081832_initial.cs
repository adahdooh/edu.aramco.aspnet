using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace edu.aramco.aspnet.scaffold.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "_zz",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        emp_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        verify_type = table.Column<int>(type: "int", nullable: false),
            //        work_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        terminal_sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        terminal_alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        area_alias = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        longitude = table.Column<double>(type: "float", nullable: true),
            //        latitude = table.Column<double>(type: "float", nullable: true),
            //        gps_location = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        source = table.Column<short>(type: "smallint", nullable: true),
            //        purpose = table.Column<short>(type: "smallint", nullable: true),
            //        crc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        is_attendance = table.Column<short>(type: "smallint", nullable: true),
            //        reserved = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sync_status = table.Column<short>(type: "smallint", nullable: true),
            //        sync_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        is_mask = table.Column<short>(type: "smallint", nullable: true),
            //        temperature = table.Column<decimal>(type: "numeric(4,1)", nullable: true),
            //        emp_id = table.Column<int>(type: "int", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: true),
            //        company_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attcalclog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dept_id = table.Column<int>(type: "int", nullable: true),
            //        emp_id = table.Column<int>(type: "int", nullable: true),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        log_type = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_attc__3213E83FABB47B7C", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attcode",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        display_format = table.Column<short>(type: "smallint", nullable: false),
            //        symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        round_off = table.Column<short>(type: "smallint", nullable: false),
            //        min_val = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        symbol_only = table.Column<bool>(type: "bit", nullable: false),
            //        order = table.Column<short>(type: "smallint", nullable: false),
            //        color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_attc__3213E83F74E85A23", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attgroup",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_attg__3213E83F66C52FC1", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attreportsetting",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        filter_by_hire_date = table.Column<bool>(type: "bit", nullable: false),
            //        resign_emp = table.Column<short>(type: "smallint", nullable: false),
            //        short_date = table.Column<short>(type: "smallint", nullable: false),
            //        short_time = table.Column<short>(type: "smallint", nullable: false),
            //        auto_calculate = table.Column<bool>(type: "bit", nullable: false),
            //        calculate_time = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_attr__3213E83FF37C1E80", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attrule",
            //    columns: table => new
            //    {
            //        param_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        param_value = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_attr__71F4BD70FFA2CAF0", x => x.param_name);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attshift",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        cycle_unit = table.Column<short>(type: "smallint", nullable: false),
            //        shift_cycle = table.Column<int>(type: "int", nullable: false),
            //        work_weekend = table.Column<bool>(type: "bit", nullable: false),
            //        weekend_type = table.Column<short>(type: "smallint", nullable: false),
            //        work_day_off = table.Column<bool>(type: "bit", nullable: false),
            //        day_off_type = table.Column<short>(type: "smallint", nullable: false),
            //        auto_shift = table.Column<short>(type: "smallint", nullable: false),
            //        enable_ot_rule = table.Column<bool>(type: "bit", nullable: false),
            //        frequency = table.Column<short>(type: "smallint", nullable: false),
            //        ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_atts__3213E83F8F37AED3", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_calculatelastdate",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        last_date = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_calc__3213E83FC12B6AB0", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_calculatetask",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        emp = table.Column<int>(type: "int", nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        @event = table.Column<string>(name: "event", type: "nvarchar(128)", maxLength: 128, nullable: true),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        execute_time = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_calc__3213E83FE5D6D6FF", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_leavegroup",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_leav__3213E83FA3C37CC4", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_paycode",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        code_type = table.Column<short>(type: "smallint", nullable: false),
            //        tag = table.Column<short>(type: "smallint", nullable: true),
            //        fixed_code = table.Column<short>(type: "smallint", nullable: true),
            //        is_work = table.Column<bool>(type: "bit", nullable: false),
            //        fixed_hours = table.Column<decimal>(type: "numeric(8,2)", nullable: false),
            //        is_paid = table.Column<bool>(type: "bit", nullable: false),
            //        is_benefit = table.Column<bool>(type: "bit", nullable: false),
            //        round_off = table.Column<short>(type: "smallint", nullable: false),
            //        min_val = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        display_format = table.Column<short>(type: "smallint", nullable: false),
            //        symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        display_order = table.Column<short>(type: "smallint", nullable: false),
            //        desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        is_display = table.Column<bool>(type: "bit", nullable: false),
            //        is_default = table.Column<bool>(type: "bit", nullable: false),
            //        color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payc__3213E83F316F6113", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadbreak",
            //    columns: table => new
            //    {
            //        uuid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
            //        break_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        break_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        duration = table.Column<int>(type: "int", nullable: true),
            //        taken = table.Column<int>(type: "int", nullable: true),
            //        actual_duration = table.Column<int>(type: "int", nullable: true),
            //        early_in = table.Column<int>(type: "int", nullable: true),
            //        late_in = table.Column<int>(type: "int", nullable: true),
            //        late = table.Column<int>(type: "int", nullable: true),
            //        early_leave = table.Column<int>(type: "int", nullable: true),
            //        absent = table.Column<int>(type: "int", nullable: true),
            //        work_time = table.Column<int>(type: "int", nullable: true),
            //        overtime = table.Column<int>(type: "int", nullable: true),
            //        weekend_ot = table.Column<int>(type: "int", nullable: true),
            //        holiday_ot = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__7F427930EB361D45", x => x.uuid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadovertime",
            //    columns: table => new
            //    {
            //        uuid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
            //        normal_wt = table.Column<int>(type: "int", nullable: true),
            //        normal_ot = table.Column<int>(type: "int", nullable: true),
            //        weekend_ot = table.Column<int>(type: "int", nullable: true),
            //        holiday_ot = table.Column<int>(type: "int", nullable: true),
            //        ot_lv1 = table.Column<int>(type: "int", nullable: true),
            //        ot_lv2 = table.Column<int>(type: "int", nullable: true),
            //        ot_lv3 = table.Column<int>(type: "int", nullable: true),
            //        total_ot = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__7F4279307230B363", x => x.uuid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_reportparam",
            //    columns: table => new
            //    {
            //        param_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        param_value = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_repo__71F4BD70ECDDCA9B", x => x.param_name);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "attparam",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        paraname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        paratype = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        paravalue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__attparam__3213E83F20E4F2B4", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "audit",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TransactionId = table.Column<long>(type: "bigint", nullable: false),
            //        EventType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        OldValue = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PunchTime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EmpCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        UpdatedByEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__audit__3214EC07D2FCA30C", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_group",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_gro__3213E83FB8A47FC2", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_user",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        first_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        last_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        emp_pin = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
            //        tele_phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        auth_time_dept = table.Column<int>(type: "int", nullable: true),
            //        login_id = table.Column<int>(type: "int", nullable: true),
            //        login_type = table.Column<int>(type: "int", nullable: true),
            //        login_count = table.Column<int>(type: "int", nullable: true),
            //        is_staff = table.Column<bool>(type: "bit", nullable: false),
            //        is_active = table.Column<bool>(type: "bit", nullable: false),
            //        is_superuser = table.Column<bool>(type: "bit", nullable: false),
            //        is_public = table.Column<bool>(type: "bit", nullable: false),
            //        can_manage_all_dept = table.Column<bool>(type: "bit", nullable: false),
            //        del_flag = table.Column<int>(type: "int", nullable: true),
            //        date_joined = table.Column<DateTime>(type: "datetime", nullable: false),
            //        last_login = table.Column<DateTime>(type: "datetime", nullable: true),
            //        session_key = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //        login_ip = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //        photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        assign_company = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_use__3213E83F1B028A3A", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_attparamdepts",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        rulename = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        deptid = table.Column<int>(type: "int", nullable: false),
            //        @operator = table.Column<string>(name: "operator", type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        optime = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_att__3213E83F3EF07E9D", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_autoattexporttask",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        task_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        task_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        @params = table.Column<string>(name: "params", type: "nvarchar(max)", nullable: true),
            //        enable = table.Column<bool>(type: "bit", nullable: false),
            //        process_time = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_aut__3213E83FE74EA489", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_autoexporttask",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        task_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        task_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        @params = table.Column<string>(name: "params", type: "nvarchar(max)", nullable: true),
            //        enable = table.Column<bool>(type: "bit", nullable: false),
            //        process_time = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_aut__3213E83FE7FB94FB", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_dbbackuplog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        db_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        db_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        @operator = table.Column<string>(name: "operator", type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        backup_file = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        backup_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        backup_status = table.Column<short>(type: "smallint", nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_dbb__3213E83F1AD7499A", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_emailtemplate",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        category = table.Column<int>(type: "int", nullable: false),
            //        sub_category = table.Column<int>(type: "int", nullable: false),
            //        @event = table.Column<int>(name: "event", type: "int", nullable: false),
            //        receiver = table.Column<int>(type: "int", nullable: false),
            //        subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        template = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        enable = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_ema__3213E83F72EC6AF2", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_eventalertsetting",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        event_id = table.Column<int>(type: "int", nullable: false),
            //        @event = table.Column<string>(name: "event", type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        module = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        sub_module = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        email_alert = table.Column<bool>(type: "bit", nullable: false),
            //        app_alert = table.Column<bool>(type: "bit", nullable: false),
            //        sms_alert = table.Column<bool>(type: "bit", nullable: false),
            //        whatapp_alert = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_eve__3213E83FA04A9A84", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_fixedexporttask",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        task_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        task_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        @params = table.Column<string>(name: "params", type: "nvarchar(max)", nullable: true),
            //        fixed_type = table.Column<short>(type: "smallint", nullable: false),
            //        enable = table.Column<bool>(type: "bit", nullable: false),
            //        process_time = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_fix__3213E83FE21568ED", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_securitypolicy",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        single_login = table.Column<bool>(type: "bit", nullable: false),
            //        app_single_user_login = table.Column<bool>(type: "bit", nullable: false),
            //        security_code = table.Column<bool>(type: "bit", nullable: false),
            //        code_length = table.Column<int>(type: "int", nullable: false),
            //        valid_duration = table.Column<int>(type: "int", nullable: false),
            //        failed_locked = table.Column<bool>(type: "bit", nullable: false),
            //        lock_failed_count = table.Column<int>(type: "int", nullable: false),
            //        lock_duration = table.Column<int>(type: "int", nullable: false),
            //        enforce_pwd_change = table.Column<bool>(type: "bit", nullable: false),
            //        enforce_pwd_expiration = table.Column<bool>(type: "bit", nullable: false),
            //        validity_period = table.Column<int>(type: "int", nullable: false),
            //        password_level = table.Column<short>(type: "smallint", nullable: false),
            //        is_default = table.Column<bool>(type: "bit", nullable: false),
            //        session_timeout = table.Column<int>(type: "int", nullable: false),
            //        export_encryption = table.Column<bool>(type: "bit", nullable: false),
            //        export_encryption_password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        app_single_device_login = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_sec__3213E83F5D62CA9C", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_sendemail",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        purpose = table.Column<int>(type: "int", nullable: false),
            //        email_to = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        email_cc = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        email_bcc = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        email_subject = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        email_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        send_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        send_status = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_sen__3213E83F1DCBBEB5", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_sftpsetting",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        host = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: false),
            //        port = table.Column<int>(type: "int", nullable: false),
            //        is_sftp = table.Column<short>(type: "smallint", nullable: false),
            //        user_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        user_password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //        user_key = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_sft__3213E83FF5E1B18D", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_sysparam",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        para_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        para_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        para_value = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_sys__3213E83F31F9AA49", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_sysparamdept",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        rule_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        dept_id = table.Column<int>(type: "int", nullable: false),
            //        @operator = table.Column<string>(name: "operator", type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        op_time = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_sys__3213E83F6A125BA6", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_systemlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        execute_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        operation = table.Column<short>(type: "smallint", nullable: false),
            //        execute_status = table.Column<short>(type: "smallint", nullable: false),
            //        description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_sys__3213E83F479CDF71", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_systemsetting",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        value = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_sys__3213E83FE45CBDAE", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_whatsapplog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        receiver = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        content = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
            //        result = table.Column<short>(type: "smallint", nullable: false),
            //        push_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        reason = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_wha__3213E83F1D62B82B", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_celery_beat_clockedschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        clocked_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        enabled = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_c__3213E83F78D44537", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_celery_beat_crontabschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        minute = table.Column<string>(type: "nvarchar(240)", maxLength: 240, nullable: false),
            //        hour = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: false),
            //        day_of_week = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //        day_of_month = table.Column<string>(type: "nvarchar(124)", maxLength: 124, nullable: false),
            //        month_of_year = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
            //        timezone = table.Column<string>(type: "nvarchar(63)", maxLength: 63, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_c__3213E83FDE35ADC0", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_celery_beat_intervalschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        every = table.Column<int>(type: "int", nullable: false),
            //        period = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_c__3213E83F821D49ED", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_celery_beat_periodictasks",
            //    columns: table => new
            //    {
            //        ident = table.Column<short>(type: "smallint", nullable: false),
            //        last_update = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_c__07D87A799C5C7E66", x => x.ident);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_celery_beat_solarschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        @event = table.Column<string>(name: "event", type: "nvarchar(24)", maxLength: 24, nullable: false),
            //        latitude = table.Column<decimal>(type: "numeric(9,6)", nullable: false),
            //        longitude = table.Column<decimal>(type: "numeric(9,6)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_c__3213E83F396FE47D", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_content_type",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        app_label = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_c__3213E83F6FEB6096", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_migrations",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        app = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        applied = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_m__3213E83F35011FEE", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_session",
            //    columns: table => new
            //    {
            //        session_key = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        session_data = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        expire_date = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_s__B3BA0F1FABA972F1", x => x.session_key);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ep_epsetup",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        temp_alarm = table.Column<bool>(type: "bit", nullable: false),
            //        temp_warning = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        temp_warning_F = table.Column<decimal>(type: "numeric(4,1)", nullable: true),
            //        temp_unit = table.Column<short>(type: "smallint", nullable: false),
            //        mask_alarm = table.Column<bool>(type: "bit", nullable: false),
            //        is_default = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__ep_epset__3213E83FF64828F9", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_devicemoduleconfig",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        enable_registration = table.Column<bool>(type: "bit", nullable: false),
            //        enable_resigned_filter = table.Column<bool>(type: "bit", nullable: false),
            //        enable_auto_add = table.Column<bool>(type: "bit", nullable: false),
            //        enable_name_upload = table.Column<bool>(type: "bit", nullable: false),
            //        enable_name_download = table.Column<bool>(type: "bit", nullable: false),
            //        enable_card_upload = table.Column<bool>(type: "bit", nullable: false),
            //        encryption = table.Column<bool>(type: "bit", nullable: false),
            //        timezone = table.Column<short>(type: "smallint", nullable: false),
            //        global_setup = table.Column<bool>(type: "bit", nullable: false),
            //        heartbeat = table.Column<int>(type: "int", nullable: false),
            //        transfer_mode = table.Column<short>(type: "smallint", nullable: false),
            //        transfer_interval = table.Column<int>(type: "int", nullable: false),
            //        transfer_time = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        sync_mode = table.Column<short>(type: "smallint", nullable: false),
            //        sync_time = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        transaction_retention = table.Column<int>(type: "int", nullable: false),
            //        command_retention = table.Column<int>(type: "int", nullable: false),
            //        dev_log_retention = table.Column<int>(type: "int", nullable: false),
            //        upload_log_retention = table.Column<int>(type: "int", nullable: false),
            //        edit_policy = table.Column<short>(type: "smallint", nullable: false),
            //        import_policy = table.Column<short>(type: "smallint", nullable: false),
            //        mobile_policy = table.Column<short>(type: "smallint", nullable: false),
            //        device_policy = table.Column<short>(type: "smallint", nullable: false),
            //        api_policy = table.Column<short>(type: "smallint", nullable: false),
            //        visitor_policy = table.Column<short>(type: "smallint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_d__3213E83F28E3D65B", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_shortmessage",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        message = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        msg_type = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_s__3213E83FA3377117", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminalemployee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        terminal_sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        emp_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        privilege = table.Column<short>(type: "smallint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83F5F1552CD", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "meeting_meetingroom",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        capacity = table.Column<int>(type: "int", nullable: false),
            //        location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        state = table.Column<short>(type: "smallint", nullable: false),
            //        enable_room = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__meeting___3213E83F6C591270", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_appactionlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        user = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        @params = table.Column<string>(name: "params", type: "nvarchar(max)", nullable: true),
            //        describe = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        request_status = table.Column<short>(type: "smallint", nullable: false),
            //        action_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        remote_ip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_a__3213E83FD6D66A48", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_applist",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        login_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        last_active = table.Column<DateTime>(type: "datetime", nullable: false),
            //        token = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        device_token = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        client_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        client_category = table.Column<short>(type: "smallint", nullable: false),
            //        active = table.Column<short>(type: "smallint", nullable: true),
            //        enable = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_a__3213E83F34289621", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_gpslocation",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        alias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        longitude = table.Column<double>(type: "float", nullable: false),
            //        latitude = table.Column<double>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_g__3213E83F28EBDDF8", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_deductionformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        formula = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F803D7EDA", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_increasementformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        formula = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F0D9E31EF", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_certification",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        cert_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        cert_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83FC9B9ACC4", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_company",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        company_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        company_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        is_default = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F9B6788A0", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employeecustomattribute",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        attr_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        attr_type = table.Column<short>(type: "smallint", nullable: false),
            //        attr_value = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        is_unique = table.Column<bool>(type: "bit", nullable: false),
            //        enable = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83FA9944455", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "sync_area",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        post_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        flag = table.Column<short>(type: "smallint", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sync_ret = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        area_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        area_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        parent_area_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__sync_are__3213E83FB3457F98", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "sync_department",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        post_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        flag = table.Column<short>(type: "smallint", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sync_ret = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        dept_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        dept_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        parent_dept_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__sync_dep__3213E83FFB4501DA", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "sync_employee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        post_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        flag = table.Column<short>(type: "smallint", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sync_ret = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        emp_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        first_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        dept_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        dept_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        job_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        job_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        area_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        area_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        card_no = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        multi_area = table.Column<bool>(type: "bit", nullable: false),
            //        hire_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        gender = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
            //        birthday = table.Column<DateTime>(type: "datetime", nullable: true),
            //        email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        active_status = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__sync_emp__3213E83FBDC915E8", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "sync_job",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        post_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        flag = table.Column<short>(type: "smallint", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sync_ret = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        job_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        job_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__sync_job__3213E83FD051ABBB", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_reason",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        visit_reason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83F69C368C1", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitorconfig",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        qr_code_policy = table.Column<short>(type: "smallint", nullable: false),
            //        code_prefix = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        code_width = table.Column<int>(type: "int", nullable: false),
            //        code_start = table.Column<int>(type: "int", nullable: false),
            //        access_limited = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        auto_delete_data = table.Column<short>(type: "smallint", nullable: false),
            //        data_retention = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83FAB2BF9A4", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_workflowrole",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        role_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        role_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83F92922045", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_groupschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        group_id = table.Column<int>(type: "int", nullable: false),
            //        shift_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_grou__3213E83F0B6F8244", x => x.id);
            //        table.ForeignKey(
            //            name: "att_groupschedule_group_id_c341493f_fk_att_attgroup_id",
            //            column: x => x.group_id,
            //            principalTable: "att_attgroup",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_groupschedule_shift_id_287e7fc0_fk_att_attshift_id",
            //            column: x => x.shift_id,
            //            principalTable: "att_attshift",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attpolicy",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        use_ot = table.Column<short>(type: "smallint", nullable: false),
            //        weekend1 = table.Column<short>(type: "smallint", nullable: false),
            //        weekend2 = table.Column<short>(type: "smallint", nullable: false),
            //        start_of_week = table.Column<short>(type: "smallint", nullable: false),
            //        max_hrs = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        day_change = table.Column<DateTime>(type: "datetime", nullable: false),
            //        paring_rule = table.Column<short>(type: "smallint", nullable: false),
            //        overtime_policy = table.Column<short>(type: "smallint", nullable: false),
            //        punch_period = table.Column<short>(type: "smallint", nullable: false),
            //        daily_ot = table.Column<bool>(type: "bit", nullable: false),
            //        daily_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        weekly_ot = table.Column<bool>(type: "bit", nullable: false),
            //        weekly_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        weekend_ot = table.Column<bool>(type: "bit", nullable: false),
            //        weekend_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        holiday_ot = table.Column<bool>(type: "bit", nullable: false),
            //        holiday_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        late_in2absence = table.Column<int>(type: "int", nullable: false),
            //        early_out2absence = table.Column<int>(type: "int", nullable: false),
            //        miss_in = table.Column<short>(type: "smallint", nullable: false),
            //        late_in_hrs = table.Column<int>(type: "int", nullable: false),
            //        miss_out = table.Column<short>(type: "smallint", nullable: false),
            //        early_out_hrs = table.Column<int>(type: "int", nullable: false),
            //        require_capture = table.Column<bool>(type: "bit", nullable: false),
            //        require_work_code = table.Column<bool>(type: "bit", nullable: false),
            //        require_punch_state = table.Column<bool>(type: "bit", nullable: false),
            //        max_late_in = table.Column<short>(type: "smallint", nullable: false),
            //        max_early_out = table.Column<short>(type: "smallint", nullable: false),
            //        max_absent = table.Column<short>(type: "smallint", nullable: false),
            //        global_frequency = table.Column<short>(type: "smallint", nullable: false),
            //        global_send_day = table.Column<short>(type: "smallint", nullable: false),
            //        email_send_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        sending_day = table.Column<short>(type: "smallint", nullable: false),
            //        weekend1_color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        weekend2_color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        ot_pay_code_id = table.Column<int>(type: "int", nullable: true),
            //        enable_compensatory = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_attp__3213E83F7A8C2DC2", x => x.id);
            //        table.ForeignKey(
            //            name: "att_attpolicy_ot_pay_code_id_b189b952_fk_att_paycode_id",
            //            column: x => x.ot_pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_breaktime",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        period_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        end_margin = table.Column<int>(type: "int", nullable: false),
            //        func_key = table.Column<short>(type: "smallint", nullable: false),
            //        available_interval_type = table.Column<short>(type: "smallint", nullable: false),
            //        available_interval = table.Column<int>(type: "int", nullable: false),
            //        multiple_punch = table.Column<short>(type: "smallint", nullable: false),
            //        calc_type = table.Column<short>(type: "smallint", nullable: false),
            //        minimum_duration = table.Column<int>(type: "int", nullable: true),
            //        early_in = table.Column<short>(type: "smallint", nullable: false),
            //        late_in = table.Column<short>(type: "smallint", nullable: false),
            //        profit_rule = table.Column<bool>(type: "bit", nullable: false),
            //        min_early_in = table.Column<int>(type: "int", nullable: false),
            //        loss_rule = table.Column<bool>(type: "bit", nullable: false),
            //        min_late_in = table.Column<int>(type: "int", nullable: false),
            //        loss_code_id = table.Column<int>(type: "int", nullable: true),
            //        profit_code_id = table.Column<int>(type: "int", nullable: true),
            //        with_salary = table.Column<short>(type: "smallint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_brea__3213E83F2E0F8FF6", x => x.id);
            //        table.ForeignKey(
            //            name: "att_breaktime_loss_code_id_2ffb5432_fk_att_paycode_id",
            //            column: x => x.loss_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_breaktime_profit_code_id_63cdbbcc_fk_att_paycode_id",
            //            column: x => x.profit_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_grouppolicy",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        use_ot = table.Column<short>(type: "smallint", nullable: false),
            //        weekend1 = table.Column<short>(type: "smallint", nullable: false),
            //        weekend2 = table.Column<short>(type: "smallint", nullable: false),
            //        start_of_week = table.Column<short>(type: "smallint", nullable: false),
            //        max_hrs = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        day_change = table.Column<DateTime>(type: "datetime", nullable: false),
            //        paring_rule = table.Column<short>(type: "smallint", nullable: false),
            //        overtime_policy = table.Column<short>(type: "smallint", nullable: false),
            //        punch_period = table.Column<short>(type: "smallint", nullable: false),
            //        daily_ot = table.Column<bool>(type: "bit", nullable: false),
            //        daily_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        weekly_ot = table.Column<bool>(type: "bit", nullable: false),
            //        weekly_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        weekend_ot = table.Column<bool>(type: "bit", nullable: false),
            //        weekend_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        holiday_ot = table.Column<bool>(type: "bit", nullable: false),
            //        holiday_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        late_in2absence = table.Column<int>(type: "int", nullable: false),
            //        early_out2absence = table.Column<int>(type: "int", nullable: false),
            //        miss_in = table.Column<short>(type: "smallint", nullable: false),
            //        late_in_hrs = table.Column<int>(type: "int", nullable: false),
            //        miss_out = table.Column<short>(type: "smallint", nullable: false),
            //        early_out_hrs = table.Column<int>(type: "int", nullable: false),
            //        require_capture = table.Column<bool>(type: "bit", nullable: false),
            //        require_work_code = table.Column<bool>(type: "bit", nullable: false),
            //        require_punch_state = table.Column<bool>(type: "bit", nullable: false),
            //        max_late_in = table.Column<short>(type: "smallint", nullable: false),
            //        max_early_out = table.Column<short>(type: "smallint", nullable: false),
            //        max_absent = table.Column<short>(type: "smallint", nullable: false),
            //        group_frequency = table.Column<short>(type: "smallint", nullable: false),
            //        group_send_day = table.Column<short>(type: "smallint", nullable: false),
            //        email_send_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        sending_day = table.Column<short>(type: "smallint", nullable: false),
            //        weekend1_color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        weekend2_color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        group_id = table.Column<int>(type: "int", nullable: false),
            //        ot_pay_code_id = table.Column<int>(type: "int", nullable: true),
            //        enable_compensatory = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_grou__3213E83FF6EECBC1", x => x.id);
            //        table.ForeignKey(
            //            name: "att_grouppolicy_group_id_b2e4dfe8_fk_att_attgroup_id",
            //            column: x => x.group_id,
            //            principalTable: "att_attgroup",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_grouppolicy_ot_pay_code_id_1ec83080_fk_att_paycode_id",
            //            column: x => x.ot_pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_leavegroupdetail",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        leave_type = table.Column<int>(type: "int", nullable: false),
            //        allow_leave_day = table.Column<int>(type: "int", nullable: false),
            //        min_leave_day = table.Column<double>(type: "float", nullable: false),
            //        deduct_holiday_day = table.Column<short>(type: "smallint", nullable: false),
            //        leave_entitlement = table.Column<int>(type: "int", nullable: true),
            //        leave_interval = table.Column<int>(type: "int", nullable: false),
            //        leave_distribution_time = table.Column<int>(type: "int", nullable: true),
            //        start_day = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        set_hire_day = table.Column<short>(type: "smallint", nullable: false),
            //        allow_exceed_limit = table.Column<short>(type: "smallint", nullable: false),
            //        allow_balance = table.Column<short>(type: "smallint", nullable: false),
            //        max_balance = table.Column<int>(type: "int", nullable: true),
            //        entitlement_detail = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
            //        leave_group_id = table.Column<int>(type: "int", nullable: false),
            //        pay_code_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_leav__3213E83F37F3288D", x => x.id);
            //        table.ForeignKey(
            //            name: "att_leavegroupdetail_leave_group_id_28f69ada_fk_att_leavegroup_id",
            //            column: x => x.leave_group_id,
            //            principalTable: "att_leavegroup",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_leavegroupdetail_pay_code_id_5013b373_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_overtimepolicy",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        mode = table.Column<short>(type: "smallint", nullable: false),
            //        hrs_from = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        hrs_to = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        master = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
            //        overnight_pay_code_id = table.Column<int>(type: "int", nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_over__3213E83FD3500700", x => x.id);
            //        table.ForeignKey(
            //            name: "att_overtimepolicy_overnight_pay_code_id_274ce1b0_fk_att_paycode_id",
            //            column: x => x.overnight_pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_overtimepolicy_pay_code_id_285b0a61_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_timeinterval",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        use_mode = table.Column<short>(type: "smallint", nullable: false),
            //        in_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        in_ahead_margin = table.Column<int>(type: "int", nullable: false),
            //        in_above_margin = table.Column<int>(type: "int", nullable: false),
            //        out_ahead_margin = table.Column<int>(type: "int", nullable: false),
            //        out_above_margin = table.Column<int>(type: "int", nullable: false),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        in_required = table.Column<short>(type: "smallint", nullable: false),
            //        out_required = table.Column<short>(type: "smallint", nullable: false),
            //        allow_late = table.Column<int>(type: "int", nullable: false),
            //        allow_leave_early = table.Column<int>(type: "int", nullable: false),
            //        work_day = table.Column<double>(type: "float", nullable: false),
            //        early_in = table.Column<short>(type: "smallint", nullable: false),
            //        min_early_in = table.Column<int>(type: "int", nullable: false),
            //        count_early_in_interval = table.Column<bool>(type: "bit", nullable: false),
            //        late_out = table.Column<short>(type: "smallint", nullable: false),
            //        min_late_out = table.Column<int>(type: "int", nullable: false),
            //        count_late_out_interval = table.Column<bool>(type: "bit", nullable: false),
            //        overtime_lv = table.Column<short>(type: "smallint", nullable: false),
            //        overtime_lv1 = table.Column<short>(type: "smallint", nullable: false),
            //        overtime_lv2 = table.Column<short>(type: "smallint", nullable: false),
            //        overtime_lv3 = table.Column<short>(type: "smallint", nullable: false),
            //        multiple_punch = table.Column<short>(type: "smallint", nullable: false),
            //        available_interval_type = table.Column<short>(type: "smallint", nullable: false),
            //        available_interval = table.Column<int>(type: "int", nullable: false),
            //        work_time_duration = table.Column<int>(type: "int", nullable: false),
            //        func_key = table.Column<short>(type: "smallint", nullable: false),
            //        work_type = table.Column<short>(type: "smallint", nullable: false),
            //        day_change = table.Column<DateTime>(type: "datetime", nullable: false),
            //        enable_early_in = table.Column<bool>(type: "bit", nullable: false),
            //        enable_late_out = table.Column<bool>(type: "bit", nullable: false),
            //        enable_overtime = table.Column<bool>(type: "bit", nullable: false),
            //        ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        enable_max_ot_limit = table.Column<bool>(type: "bit", nullable: false),
            //        max_ot_limit = table.Column<int>(type: "int", nullable: false),
            //        overtime_policy = table.Column<short>(type: "smallint", nullable: false),
            //        ot_pay_code_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_time__3213E83FBBF762AE", x => x.id);
            //        table.ForeignKey(
            //            name: "att_timeinterval_ot_pay_code_id_17438af8_fk_att_paycode_id",
            //            column: x => x.ot_pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_exceptionformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        formula = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83FDCEC551E", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_exceptionformula_pay_code_id_97609b51_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_leaveformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        formula = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F00DF0F06", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_leaveformula_pay_code_id_63c7b4bd_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_overtimeformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        formula = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83FD3C1605B", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_overtimeformula_pay_code_id_36d2f10e_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "accounts_adminbiodata",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        bio_tmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        bio_no = table.Column<int>(type: "int", nullable: true),
            //        bio_index = table.Column<int>(type: "int", nullable: true),
            //        bio_type = table.Column<int>(type: "int", nullable: false),
            //        major_ver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        minor_ver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        bio_format = table.Column<int>(type: "int", nullable: true),
            //        valid = table.Column<bool>(type: "bit", nullable: false),
            //        duress = table.Column<bool>(type: "bit", nullable: false),
            //        admin_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__accounts__3213E83F4A3A92AA", x => x.id);
            //        table.ForeignKey(
            //            name: "accounts_adminbiodata_admin_id_1e6d2d45_fk_auth_user_id",
            //            column: x => x.admin_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "accounts_usernotification",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        category = table.Column<int>(type: "int", nullable: true),
            //        @event = table.Column<int>(name: "event", type: "int", nullable: true),
            //        content = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        send_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        read_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        user_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__accounts__3213E83FE3FC8FFC", x => x.id);
            //        table.ForeignKey(
            //            name: "accounts_usernotification_user_id_b86755b3_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_user_groups",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        myuser_id = table.Column<int>(type: "int", nullable: false),
            //        group_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_use__3213E83F9DA4A750", x => x.id);
            //        table.ForeignKey(
            //            name: "auth_user_groups_group_id_97559544_fk_auth_group_id",
            //            column: x => x.group_id,
            //            principalTable: "auth_group",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "auth_user_groups_myuser_id_d03e8dcc_fk_auth_user_id",
            //            column: x => x.myuser_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_user_profile",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        login_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        pin_tabs = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        disabled_fields = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        column_order = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        preferences = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        pwd_update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        user_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_use__3213E83F82A40940", x => x.id);
            //        table.ForeignKey(
            //            name: "auth_user_profile_user_id_f9aded29_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "authtoken_token",
            //    columns: table => new
            //    {
            //        key = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        created = table.Column<DateTime>(type: "datetime", nullable: false),
            //        user_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__authtoke__DFD83CAEE3FD0679", x => x.key);
            //        table.ForeignKey(
            //            name: "authtoken_token_user_id_35299eff_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "rest_framework_tracking_apirequestlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        requested_at = table.Column<DateTime>(type: "datetime", nullable: false),
            //        response_ms = table.Column<int>(type: "int", nullable: false),
            //        path = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        remote_addr = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: false),
            //        host = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        method = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        query_params = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        response = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        status_code = table.Column<int>(type: "int", nullable: true),
            //        user_id = table.Column<int>(type: "int", nullable: true),
            //        view = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        view_method = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        errors = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        username_persistent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__rest_fra__3213E83F0525C20C", x => x.id);
            //        table.ForeignKey(
            //            name: "rest_framework_tracking_apirequestlog_user_id_671b70b7_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_celery_beat_periodictask",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        task = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        args = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        kwargs = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        queue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        exchange = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        routing_key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        expires = table.Column<DateTime>(type: "datetime", nullable: true),
            //        enabled = table.Column<bool>(type: "bit", nullable: false),
            //        last_run_at = table.Column<DateTime>(type: "datetime", nullable: true),
            //        total_run_count = table.Column<int>(type: "int", nullable: false),
            //        date_changed = table.Column<DateTime>(type: "datetime", nullable: false),
            //        description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        crontab_id = table.Column<int>(type: "int", nullable: true),
            //        interval_id = table.Column<int>(type: "int", nullable: true),
            //        solar_id = table.Column<int>(type: "int", nullable: true),
            //        one_off = table.Column<bool>(type: "bit", nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        priority = table.Column<int>(type: "int", nullable: true),
            //        headers = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        clocked_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_c__3213E83FFBC5D481", x => x.id);
            //        table.ForeignKey(
            //            name: "django_celery_beat_periodictask_clocked_id_47a69f82_fk_django_celery_beat_clockedschedule_id",
            //            column: x => x.clocked_id,
            //            principalTable: "django_celery_beat_clockedschedule",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "django_celery_beat_periodictask_crontab_id_d3cba168_fk_django_celery_beat_crontabschedule_id",
            //            column: x => x.crontab_id,
            //            principalTable: "django_celery_beat_crontabschedule",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "django_celery_beat_periodictask_interval_id_a8ca27da_fk_django_celery_beat_intervalschedule_id",
            //            column: x => x.interval_id,
            //            principalTable: "django_celery_beat_intervalschedule",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "django_celery_beat_periodictask_solar_id_a87ce72c_fk_django_celery_beat_solarschedule_id",
            //            column: x => x.solar_id,
            //            principalTable: "django_celery_beat_solarschedule",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_permission",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        content_type_id = table.Column<int>(type: "int", nullable: false),
            //        codename = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_per__3213E83FD131D0C9", x => x.id);
            //        table.ForeignKey(
            //            name: "auth_permission_content_type_id_2f476e4b_fk_django_content_type_id",
            //            column: x => x.content_type_id,
            //            principalTable: "django_content_type",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_adminlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        targets = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        targets_repr = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        action_status = table.Column<short>(type: "smallint", nullable: false),
            //        description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ip_address = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: true),
            //        can_routable = table.Column<bool>(type: "bit", nullable: false),
            //        op_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        content_type_id = table.Column<int>(type: "int", nullable: true),
            //        user_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_adm__3213E83FA4B6B045", x => x.id);
            //        table.ForeignKey(
            //            name: "base_adminlog_content_type_id_3e553c30_fk_django_content_type_id",
            //            column: x => x.content_type_id,
            //            principalTable: "django_content_type",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "base_adminlog_user_id_ecf659f8_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_bookmark",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        filters = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
            //        is_share = table.Column<bool>(type: "bit", nullable: false),
            //        time_saved = table.Column<DateTime>(type: "datetime", nullable: false),
            //        content_type_id = table.Column<int>(type: "int", nullable: false),
            //        user_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_boo__3213E83FFA1D51C0", x => x.id);
            //        table.ForeignKey(
            //            name: "base_bookmark_content_type_id_b6a0e799_fk_django_content_type_id",
            //            column: x => x.content_type_id,
            //            principalTable: "django_content_type",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "base_bookmark_user_id_5f2d5ca2_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "django_admin_log",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        action_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        object_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        object_repr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        action_flag = table.Column<short>(type: "smallint", nullable: false),
            //        change_message = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        content_type_id = table.Column<int>(type: "int", nullable: true),
            //        user_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__django_a__3213E83FCA97EE6B", x => x.id);
            //        table.ForeignKey(
            //            name: "django_admin_log_content_type_id_c4bce8eb_fk_django_content_type_id",
            //            column: x => x.content_type_id,
            //            principalTable: "django_content_type",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "django_admin_log_user_id_c564eba6_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_autoimporttask",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        task_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        task_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        @params = table.Column<string>(name: "params", type: "nvarchar(max)", nullable: true),
            //        enable = table.Column<bool>(type: "bit", nullable: false),
            //        process_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        company_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_aut__3213E83FE0F3D7F6", x => x.id);
            //        table.ForeignKey(
            //            name: "base_autoimporttask_company_id_d18431a1_fk_personnel_company_id",
            //            column: x => x.company_id,
            //            principalTable: "personnel_company",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminalworkcode",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        code = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
            //        alias = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: false),
            //        last_activity = table.Column<DateTime>(type: "datetime", nullable: true),
            //        company_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83F8AC7BDEF", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_terminalworkcode_company_id_77625f26_fk_personnel_company_id",
            //            column: x => x.company_id,
            //            principalTable: "personnel_company",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_area",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        area_code = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        area_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        is_default = table.Column<bool>(type: "bit", nullable: false),
            //        parent_area_id = table.Column<int>(type: "int", nullable: true),
            //        device_count = table.Column<int>(type: "int", nullable: false),
            //        employee_count = table.Column<int>(type: "int", nullable: false),
            //        company_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F702930A3", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_area_company_id_59750eb5_fk_personnel_company_id",
            //            column: x => x.company_id,
            //            principalTable: "personnel_company",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_area_parent_area_id_39028fda_fk_personnel_area_id",
            //            column: x => x.parent_area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_position",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        position_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        position_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        is_default = table.Column<bool>(type: "bit", nullable: false),
            //        parent_position_id = table.Column<int>(type: "int", nullable: true),
            //        company_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F93C2A322", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_position_company_id_f06c5d2a_fk_personnel_company_id",
            //            column: x => x.company_id,
            //            principalTable: "personnel_company",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_position_parent_position_id_a496a36b_fk_personnel_position_id",
            //            column: x => x.parent_position_id,
            //            principalTable: "personnel_position",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_shiftdetail",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        in_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        out_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        day_index = table.Column<int>(type: "int", nullable: false),
            //        shift_id = table.Column<int>(type: "int", nullable: false),
            //        time_interval_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_shif__3213E83FD63ECD18", x => x.id);
            //        table.ForeignKey(
            //            name: "att_shiftdetail_shift_id_7d694501_fk_att_attshift_id",
            //            column: x => x.shift_id,
            //            principalTable: "att_attshift",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_shiftdetail_time_interval_id_777dde8f_fk_att_timeinterval_id",
            //            column: x => x.time_interval_id,
            //            principalTable: "att_timeinterval",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_timeinterval_break_time",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        timeinterval_id = table.Column<int>(type: "int", nullable: false),
            //        breaktime_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_time__3213E83FFD6E8661", x => x.id);
            //        table.ForeignKey(
            //            name: "att_timeinterval_break_time_breaktime_id_08462308_fk_att_breaktime_id",
            //            column: x => x.breaktime_id,
            //            principalTable: "att_breaktime",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_timeinterval_break_time_timeinterval_id_2287017e_fk_att_timeinterval_id",
            //            column: x => x.timeinterval_id,
            //            principalTable: "att_timeinterval",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_group_permissions",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        group_id = table.Column<int>(type: "int", nullable: false),
            //        permission_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_gro__3213E83FAE8C6E2E", x => x.id);
            //        table.ForeignKey(
            //            name: "auth_group_permissions_group_id_b120cbf9_fk_auth_group_id",
            //            column: x => x.group_id,
            //            principalTable: "auth_group",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "auth_group_permissions_permission_id_84c5c92e_fk_auth_permission_id",
            //            column: x => x.permission_id,
            //            principalTable: "auth_permission",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_user_user_permissions",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        myuser_id = table.Column<int>(type: "int", nullable: false),
            //        permission_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_use__3213E83FC77E26B6", x => x.id);
            //        table.ForeignKey(
            //            name: "auth_user_user_permissions_myuser_id_679b1527_fk_auth_user_id",
            //            column: x => x.myuser_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "auth_user_user_permissions_permission_id_1fbb5f2c_fk_auth_permission_id",
            //            column: x => x.permission_id,
            //            principalTable: "auth_permission",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "guardian_groupobjectpermission",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        object_pk = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        content_type_id = table.Column<int>(type: "int", nullable: false),
            //        group_id = table.Column<int>(type: "int", nullable: false),
            //        permission_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__guardian__3213E83FBCB43531", x => x.id);
            //        table.ForeignKey(
            //            name: "guardian_groupobjectpermission_content_type_id_7ade36b8_fk_django_content_type_id",
            //            column: x => x.content_type_id,
            //            principalTable: "django_content_type",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "guardian_groupobjectpermission_group_id_4bbbfb62_fk_auth_group_id",
            //            column: x => x.group_id,
            //            principalTable: "auth_group",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "guardian_groupobjectpermission_permission_id_36572738_fk_auth_permission_id",
            //            column: x => x.permission_id,
            //            principalTable: "auth_permission",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "guardian_userobjectpermission",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        object_pk = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        content_type_id = table.Column<int>(type: "int", nullable: false),
            //        permission_id = table.Column<int>(type: "int", nullable: false),
            //        user_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__guardian__3213E83F57F16A44", x => x.id);
            //        table.ForeignKey(
            //            name: "guardian_userobjectpermission_content_type_id_2e892405_fk_django_content_type_id",
            //            column: x => x.content_type_id,
            //            principalTable: "django_content_type",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "guardian_userobjectpermission_permission_id_71807bfc_fk_auth_permission_id",
            //            column: x => x.permission_id,
            //            principalTable: "auth_permission",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "guardian_userobjectpermission_user_id_d5c1e964_fk_auth_user_id",
            //            column: x => x.user_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "acc_acccombination",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        combination_no = table.Column<int>(type: "int", nullable: false),
            //        combination_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        group1 = table.Column<int>(type: "int", nullable: true),
            //        group2 = table.Column<int>(type: "int", nullable: true),
            //        group3 = table.Column<int>(type: "int", nullable: true),
            //        group4 = table.Column<int>(type: "int", nullable: true),
            //        group5 = table.Column<int>(type: "int", nullable: true),
            //        remark = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        area_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__acc_accc__3213E83F2B597383", x => x.id);
            //        table.ForeignKey(
            //            name: "acc_acccombination_area_id_0d22c34e_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "acc_accgroups",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        group_no = table.Column<int>(type: "int", nullable: false),
            //        group_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        verify_mode = table.Column<int>(type: "int", nullable: false),
            //        timezone1 = table.Column<int>(type: "int", nullable: true),
            //        timezone2 = table.Column<int>(type: "int", nullable: true),
            //        timezone3 = table.Column<int>(type: "int", nullable: true),
            //        is_include_holiday = table.Column<short>(type: "smallint", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        area_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__acc_accg__3213E83F2296EC51", x => x.id);
            //        table.ForeignKey(
            //            name: "acc_accgroups_area_id_b83745c3_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "acc_acctimezone",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        timezone_no = table.Column<int>(type: "int", nullable: false),
            //        timezone_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        sun_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        sun_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        sun_on = table.Column<short>(type: "smallint", nullable: true),
            //        mon_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        mon_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        mon_on = table.Column<short>(type: "smallint", nullable: true),
            //        tue_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        tue_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        tue_on = table.Column<short>(type: "smallint", nullable: true),
            //        wed_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        wed_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        wed_on = table.Column<short>(type: "smallint", nullable: true),
            //        thu_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        thu_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        thu_on = table.Column<short>(type: "smallint", nullable: true),
            //        fri_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        fri_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        fri_on = table.Column<short>(type: "smallint", nullable: true),
            //        sat_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        sat_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        sat_on = table.Column<short>(type: "smallint", nullable: true),
            //        remark = table.Column<string>(type: "nvarchar(999)", maxLength: 999, nullable: true),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        area_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__acc_acct__3213E83FE6B6EBDF", x => x.id);
            //        table.ForeignKey(
            //            name: "acc_acctimezone_area_id_e9ce7a7a_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_user_auth_area",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        myuser_id = table.Column<int>(type: "int", nullable: false),
            //        area_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_use__3213E83FE3B71CFF", x => x.id);
            //        table.ForeignKey(
            //            name: "auth_user_auth_area_area_id_d1e54c70_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "auth_user_auth_area_myuser_id_5fb9a803_fk_auth_user_id",
            //            column: x => x.myuser_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminal",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        ip_address = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: false),
            //        terminal_tz = table.Column<short>(type: "smallint", nullable: false),
            //        heartbeat = table.Column<int>(type: "int", nullable: false),
            //        transfer_mode = table.Column<short>(type: "smallint", nullable: false),
            //        transfer_interval = table.Column<int>(type: "int", nullable: false),
            //        transfer_time = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        fw_ver = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        push_protocol = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        push_ver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        language = table.Column<int>(type: "int", nullable: true),
            //        terminal_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        platform = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        oem_vendor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        user_count = table.Column<int>(type: "int", nullable: true),
            //        transaction_count = table.Column<int>(type: "int", nullable: true),
            //        fp_count = table.Column<int>(type: "int", nullable: true),
            //        fp_alg_ver = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        face_count = table.Column<int>(type: "int", nullable: true),
            //        face_alg_ver = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        fv_count = table.Column<int>(type: "int", nullable: true),
            //        fv_alg_ver = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        palm_count = table.Column<int>(type: "int", nullable: true),
            //        palm_alg_ver = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        lock_func = table.Column<short>(type: "smallint", nullable: false),
            //        log_stamp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        op_log_stamp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        capture_stamp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        real_ip = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: true),
            //        state = table.Column<int>(type: "int", nullable: false),
            //        product_type = table.Column<short>(type: "smallint", nullable: true),
            //        is_attendance = table.Column<short>(type: "smallint", nullable: false),
            //        is_registration = table.Column<short>(type: "smallint", nullable: false),
            //        purpose = table.Column<short>(type: "smallint", nullable: true),
            //        controller_type = table.Column<short>(type: "smallint", nullable: true),
            //        authentication = table.Column<short>(type: "smallint", nullable: false),
            //        style = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        upload_flag = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        is_tft = table.Column<bool>(type: "bit", nullable: false),
            //        last_activity = table.Column<DateTime>(type: "datetime", nullable: true),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        push_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        is_access = table.Column<short>(type: "smallint", nullable: false),
            //        area_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83F8C21BDCB", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_terminal_area_id_c019c6f0_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "acc_accterminal",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        door_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        door_lock_delay = table.Column<int>(type: "int", nullable: false),
            //        door_sensor_delay = table.Column<int>(type: "int", nullable: false),
            //        door_sensor_type = table.Column<short>(type: "smallint", nullable: false),
            //        door_alarm_delay = table.Column<int>(type: "int", nullable: false),
            //        retry_times = table.Column<short>(type: "smallint", nullable: false),
            //        valid_holiday = table.Column<short>(type: "smallint", nullable: false),
            //        nc_time_period = table.Column<int>(type: "int", nullable: false),
            //        no_time_period = table.Column<int>(type: "int", nullable: false),
            //        speaker_alarm = table.Column<short>(type: "smallint", nullable: false),
            //        duress_fun_on = table.Column<short>(type: "smallint", nullable: false),
            //        alarm_1_1 = table.Column<short>(type: "smallint", nullable: false),
            //        alarm_1_n = table.Column<short>(type: "smallint", nullable: false),
            //        alarm_password = table.Column<short>(type: "smallint", nullable: false),
            //        duress_alarm_delay = table.Column<int>(type: "int", nullable: false),
            //        anti_passback_mode = table.Column<short>(type: "smallint", nullable: false),
            //        anti_door_direction = table.Column<short>(type: "smallint", nullable: false),
            //        verify_mode_485 = table.Column<short>(type: "smallint", nullable: false),
            //        push_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__acc_acct__3213E83FCBF8D5A3", x => x.id);
            //        table.ForeignKey(
            //            name: "acc_accterminal_terminal_id_fc92cce2_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_errorcommandlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        error_code = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
            //        error_msg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        data_origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        cmd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        additional = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_e__3213E83F377D6C37", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_errorcommandlog_terminal_id_3b2d7cbd_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_publicmessage",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        last_send = table.Column<DateTime>(type: "datetime", nullable: true),
            //        message_id = table.Column<int>(type: "int", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_p__3213E83FC11490B7", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_publicmessage_message_id_7d125e28_fk_iclock_shortmessage_id",
            //            column: x => x.message_id,
            //            principalTable: "iclock_shortmessage",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "iclock_publicmessage_terminal_id_c3b5e4cf_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminalcommand",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        content = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        commit_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        transfer_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        return_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        return_value = table.Column<int>(type: "int", nullable: true),
            //        package = table.Column<int>(type: "int", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83FB34E6FC1", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_terminalcommand_terminal_id_3dcf836f_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminalcommandlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        content = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        commit_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        transfer_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        return_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        return_value = table.Column<int>(type: "int", nullable: true),
            //        package = table.Column<int>(type: "int", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: false),
            //        cmd_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83F40BB4D30", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_terminalcommandlog_terminal_id_35ea8b2b_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminallog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        terminal_tz = table.Column<short>(type: "smallint", nullable: true),
            //        admin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        action_name = table.Column<short>(type: "smallint", nullable: true),
            //        action_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        @object = table.Column<string>(name: "object", type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        param1 = table.Column<int>(type: "int", nullable: true),
            //        param2 = table.Column<int>(type: "int", nullable: true),
            //        param3 = table.Column<int>(type: "int", nullable: true),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83FDB6B63C0", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_terminallog_terminal_id_667b3ea7_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminalparameter",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        param_type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        param_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        param_value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83FAB9CE792", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_terminalparameter_terminal_id_443872e3_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_terminaluploadlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        @event = table.Column<string>(name: "event", type: "nvarchar(80)", maxLength: 80, nullable: false),
            //        content = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
            //        upload_count = table.Column<int>(type: "int", nullable: false),
            //        error_count = table.Column<int>(type: "int", nullable: false),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83F864F9EF9", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_terminaluploadlog_terminal_id_9c9a7664_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_transactionproofcmd",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        action_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        terminal_count = table.Column<int>(type: "int", nullable: true),
            //        server_count = table.Column<int>(type: "int", nullable: true),
            //        flag = table.Column<short>(type: "smallint", nullable: true),
            //        reserved_init = table.Column<int>(type: "int", nullable: true),
            //        reserved_float = table.Column<double>(type: "float", nullable: true),
            //        reserved_char = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83FF35058AC", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_transactionproofcmd_terminal_id_08b81e1e_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "meeting_meetingroomdevice",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        device_id = table.Column<int>(type: "int", nullable: false),
            //        room_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__meeting___3213E83F434654C1", x => x.id);
            //        table.ForeignKey(
            //            name: "meeting_meetingroomdevice_device_id_a09e8a7d_fk_iclock_terminal_id",
            //            column: x => x.device_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "meeting_meetingroomdevice_room_id_e000d78d_fk_meeting_meetingroom_id",
            //            column: x => x.room_id,
            //            principalTable: "meeting_meetingroom",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "acc_accholiday",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        area_id = table.Column<int>(type: "int", nullable: false),
            //        holiday_id = table.Column<int>(type: "int", nullable: false),
            //        timezone_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__acc_acch__3213E83F2EEEB971", x => x.id);
            //        table.ForeignKey(
            //            name: "acc_accholiday_area_id_d15c19da_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "acc_accholiday_timezone_id_450d2d1e_fk_acc_acctimezone_id",
            //            column: x => x.timezone_id,
            //            principalTable: "acc_acctimezone",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "acc_accprivilege",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        is_group_timezone = table.Column<short>(type: "smallint", nullable: false),
            //        timezone1 = table.Column<int>(type: "int", nullable: true),
            //        timezone2 = table.Column<int>(type: "int", nullable: true),
            //        timezone3 = table.Column<int>(type: "int", nullable: true),
            //        is_group_verifycode = table.Column<short>(type: "smallint", nullable: false),
            //        verify_mode = table.Column<int>(type: "int", nullable: true),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        area_id = table.Column<int>(type: "int", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        group_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__acc_accp__3213E83FA90F9B9D", x => x.id);
            //        table.ForeignKey(
            //            name: "acc_accprivilege_area_id_2123ff6f_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "acc_accprivilege_group_id_c5ed7003_fk_acc_accgroups_id",
            //            column: x => x.group_id,
            //            principalTable: "acc_accgroups",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attemployee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        enable_attendance = table.Column<bool>(type: "bit", nullable: false),
            //        enable_schedule = table.Column<bool>(type: "bit", nullable: false),
            //        enable_overtime = table.Column<bool>(type: "bit", nullable: false),
            //        enable_holiday = table.Column<bool>(type: "bit", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        group_id = table.Column<int>(type: "int", nullable: true),
            //        enable_compensatory = table.Column<bool>(type: "bit", nullable: false),
            //        ip_address = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_atte__3213E83F84675660", x => x.id);
            //        table.ForeignKey(
            //            name: "att_attemployee_group_id_18d3954d_fk_att_attgroup_id",
            //            column: x => x.group_id,
            //            principalTable: "att_attgroup",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_attschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        shift_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_atts__3213E83FB3C4DDC3", x => x.id);
            //        table.ForeignKey(
            //            name: "att_attschedule_shift_id_13d2db9a_fk_att_attshift_id",
            //            column: x => x.shift_id,
            //            principalTable: "att_attshift",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_changeschedule",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        previous_timeinterval = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        apply_reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        attachment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        timeinterval_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_chan__2F050E151F71FD15", x => x.workflowinstance_ptr_id);
            //        table.ForeignKey(
            //            name: "att_changeschedule_timeinterval_id_d41ac077_fk_att_timeinterval_id",
            //            column: x => x.timeinterval_id,
            //            principalTable: "att_timeinterval",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_departmentpolicy",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        use_ot = table.Column<short>(type: "smallint", nullable: false),
            //        weekend1 = table.Column<short>(type: "smallint", nullable: false),
            //        weekend2 = table.Column<short>(type: "smallint", nullable: false),
            //        start_of_week = table.Column<short>(type: "smallint", nullable: false),
            //        max_hrs = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        day_change = table.Column<DateTime>(type: "datetime", nullable: false),
            //        paring_rule = table.Column<short>(type: "smallint", nullable: false),
            //        overtime_policy = table.Column<short>(type: "smallint", nullable: false),
            //        punch_period = table.Column<short>(type: "smallint", nullable: false),
            //        daily_ot = table.Column<bool>(type: "bit", nullable: false),
            //        daily_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        weekly_ot = table.Column<bool>(type: "bit", nullable: false),
            //        weekly_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        weekend_ot = table.Column<bool>(type: "bit", nullable: false),
            //        weekend_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        holiday_ot = table.Column<bool>(type: "bit", nullable: false),
            //        holiday_ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        late_in2absence = table.Column<int>(type: "int", nullable: false),
            //        early_out2absence = table.Column<int>(type: "int", nullable: false),
            //        miss_in = table.Column<short>(type: "smallint", nullable: false),
            //        late_in_hrs = table.Column<int>(type: "int", nullable: false),
            //        miss_out = table.Column<short>(type: "smallint", nullable: false),
            //        early_out_hrs = table.Column<int>(type: "int", nullable: false),
            //        require_capture = table.Column<bool>(type: "bit", nullable: false),
            //        require_work_code = table.Column<bool>(type: "bit", nullable: false),
            //        require_punch_state = table.Column<bool>(type: "bit", nullable: false),
            //        max_late_in = table.Column<short>(type: "smallint", nullable: false),
            //        max_early_out = table.Column<short>(type: "smallint", nullable: false),
            //        max_absent = table.Column<short>(type: "smallint", nullable: false),
            //        dept_frequency = table.Column<short>(type: "smallint", nullable: false),
            //        dept_send_day = table.Column<short>(type: "smallint", nullable: false),
            //        email_send_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        sending_day = table.Column<short>(type: "smallint", nullable: false),
            //        weekend1_color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        weekend2_color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        department_id = table.Column<int>(type: "int", nullable: false),
            //        ot_pay_code_id = table.Column<int>(type: "int", nullable: true),
            //        enable_compensatory = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_depa__3213E83F62630CFD", x => x.id);
            //        table.ForeignKey(
            //            name: "att_departmentpolicy_ot_pay_code_id_390411dd_fk_att_paycode_id",
            //            column: x => x.ot_pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_departmentschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        department_id = table.Column<int>(type: "int", nullable: false),
            //        shift_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_depa__3213E83F2C759DFC", x => x.id);
            //        table.ForeignKey(
            //            name: "att_departmentschedule_shift_id_c37d5ade_fk_att_attshift_id",
            //            column: x => x.shift_id,
            //            principalTable: "att_attshift",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_deptattrule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        rule = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        department_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_dept__3213E83F20A5E386", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_holiday",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        duration_day = table.Column<short>(type: "smallint", nullable: false),
            //        enable_ot_rule = table.Column<bool>(type: "bit", nullable: false),
            //        ot_rule = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        color_setting = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        att_group_id = table.Column<int>(type: "int", nullable: true),
            //        department_id = table.Column<int>(type: "int", nullable: true),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_holi__3213E83F1749A9B4", x => x.id);
            //        table.ForeignKey(
            //            name: "att_holiday_att_group_id_9ddf13ba_fk_att_attgroup_id",
            //            column: x => x.att_group_id,
            //            principalTable: "att_attgroup",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_leave",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        apply_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        attachment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        leave_day = table.Column<double>(type: "float", nullable: false),
            //        pay_code_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_leav__2F050E1522FFAC5E", x => x.workflowinstance_ptr_id);
            //        table.ForeignKey(
            //            name: "att_leave_pay_code_id_2fadf493_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadexception",
            //    columns: table => new
            //    {
            //        uuid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        duration = table.Column<int>(type: "int", nullable: true),
            //        days = table.Column<double>(type: "float", nullable: true),
            //        data_type = table.Column<short>(type: "smallint", nullable: false),
            //        description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        item_id = table.Column<int>(type: "int", nullable: true),
            //        skd_id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__7F42793034429B44", x => x.uuid);
            //        table.ForeignKey(
            //            name: "att_payloadexception_item_id_a08bfe48_fk_att_leave_workflowinstance_ptr_id",
            //            column: x => x.item_id,
            //            principalTable: "att_leave",
            //            principalColumn: "workflowinstance_ptr_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_leaveyearbalance",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        leave_type = table.Column<int>(type: "int", nullable: true),
            //        year = table.Column<int>(type: "int", nullable: true),
            //        entitlement_days = table.Column<short>(type: "smallint", nullable: true),
            //        leave_day = table.Column<double>(type: "float", nullable: true),
            //        pre_balance = table.Column<short>(type: "smallint", nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        pay_code_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_leav__3213E83F92537FA9", x => x.id);
            //        table.ForeignKey(
            //            name: "att_leaveyearbalance_pay_code_id_82632aca_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_manuallog",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        work_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        apply_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        attachment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_manu__2F050E1527FA3B75", x => x.workflowinstance_ptr_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_overtime",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        overtime_type = table.Column<short>(type: "smallint", nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        apply_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        attachment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_over__2F050E15B6B97BE0", x => x.workflowinstance_ptr_id);
            //        table.ForeignKey(
            //            name: "att_overtime_pay_code_id_05600ee0_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadattcode",
            //    columns: table => new
            //    {
            //        id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        week = table.Column<int>(type: "int", nullable: false),
            //        weekday = table.Column<int>(type: "int", nullable: false),
            //        att_code_alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        att_code_symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        workday = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        hours = table.Column<decimal>(type: "numeric(6,1)", nullable: false),
            //        minutes = table.Column<decimal>(type: "numeric(8,1)", nullable: false),
            //        is_weekly = table.Column<bool>(type: "bit", nullable: false),
            //        att_code_id = table.Column<int>(type: "int", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        shift_id = table.Column<int>(type: "int", nullable: true),
            //        time_card_id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__3213E83F5372FF17", x => x.id);
            //        table.ForeignKey(
            //            name: "att_payloadattcode_att_code_id_0d635efd_fk_att_attcode_id",
            //            column: x => x.att_code_id,
            //            principalTable: "att_attcode",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_payloadattcode_shift_id_731faddf_fk_att_attshift_id",
            //            column: x => x.shift_id,
            //            principalTable: "att_attshift",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadbase",
            //    columns: table => new
            //    {
            //        uuid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        weekday = table.Column<short>(type: "smallint", nullable: true),
            //        check_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        check_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        duration = table.Column<int>(type: "int", nullable: true),
            //        duty_duration = table.Column<int>(type: "int", nullable: true),
            //        work_day = table.Column<double>(type: "float", nullable: false),
            //        clock_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        clock_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        total_time = table.Column<int>(type: "int", nullable: true),
            //        duty_worked = table.Column<int>(type: "int", nullable: true),
            //        actual_worked = table.Column<int>(type: "int", nullable: true),
            //        unscheduled = table.Column<int>(type: "int", nullable: true),
            //        remaining = table.Column<int>(type: "int", nullable: true),
            //        total_worked = table.Column<int>(type: "int", nullable: true),
            //        late = table.Column<int>(type: "int", nullable: true),
            //        early_leave = table.Column<int>(type: "int", nullable: true),
            //        @short = table.Column<int>(name: "short", type: "int", nullable: true),
            //        absent = table.Column<int>(type: "int", nullable: true),
            //        leave = table.Column<int>(type: "int", nullable: true),
            //        exception = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        day_off = table.Column<short>(type: "smallint", nullable: false),
            //        break_time_id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        overtime_id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
            //        timetable_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__7F427930ED449C40", x => x.uuid);
            //        table.ForeignKey(
            //            name: "att_payloadbase_timetable_id_a389e3d8_fk_att_timeinterval_id",
            //            column: x => x.timetable_id,
            //            principalTable: "att_timeinterval",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadeffectpunch",
            //    columns: table => new
            //    {
            //        id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_datetime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        week = table.Column<short>(type: "smallint", nullable: false),
            //        weekday = table.Column<short>(type: "smallint", nullable: false),
            //        work_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        adjust_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        time_card_id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true),
            //        trans_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__3213E83F8FB11B2E", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadmulpunchset",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        weekday = table.Column<short>(type: "smallint", nullable: true),
            //        data_index = table.Column<short>(type: "smallint", nullable: false),
            //        clock_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        in_id = table.Column<int>(type: "int", nullable: true),
            //        clock_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        out_id = table.Column<int>(type: "int", nullable: true),
            //        total_time = table.Column<int>(type: "int", nullable: true),
            //        worked_time = table.Column<int>(type: "int", nullable: true),
            //        data_type = table.Column<short>(type: "smallint", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        timetable_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__3213E83FB69B5AE4", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadparing",
            //    columns: table => new
            //    {
            //        id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
            //        stamp = table.Column<long>(type: "bigint", nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        week = table.Column<short>(type: "smallint", nullable: false),
            //        weekday = table.Column<short>(type: "smallint", nullable: false),
            //        data_type = table.Column<short>(type: "smallint", nullable: false),
            //        clock_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        in_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        in_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        clock_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        out_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        out_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        worked_duration = table.Column<int>(type: "int", nullable: false),
            //        data_index = table.Column<int>(type: "int", nullable: false),
            //        workday = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        in_trans_id = table.Column<int>(type: "int", nullable: true),
            //        out_trans_id = table.Column<int>(type: "int", nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: true),
            //        time_card_id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__3213E83F05A89F69", x => x.id);
            //        table.ForeignKey(
            //            name: "att_payloadparing_pay_code_id_aa241cca_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadpaycode",
            //    columns: table => new
            //    {
            //        id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        week = table.Column<int>(type: "int", nullable: false),
            //        weekday = table.Column<int>(type: "int", nullable: false),
            //        pay_code_alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        pay_code_symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        workday = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        hours = table.Column<decimal>(type: "numeric(6,1)", nullable: false),
            //        minutes = table.Column<decimal>(type: "numeric(8,1)", nullable: false),
            //        is_exception = table.Column<short>(type: "smallint", nullable: false),
            //        is_weekly = table.Column<bool>(type: "bit", nullable: false),
            //        year = table.Column<int>(type: "int", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        pay_code_id = table.Column<int>(type: "int", nullable: false),
            //        shift_id = table.Column<int>(type: "int", nullable: true),
            //        time_card_id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__3213E83FF65BF990", x => x.id);
            //        table.ForeignKey(
            //            name: "att_payloadpaycode_pay_code_id_4a096cc7_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "att_payloadpaycode_shift_id_79a0901e_fk_att_attshift_id",
            //            column: x => x.shift_id,
            //            principalTable: "att_attshift",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadpunch",
            //    columns: table => new
            //    {
            //        uuid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        correct_state = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        orig_id = table.Column<int>(type: "int", nullable: true),
            //        skd_id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__7F427930A90FC7A9", x => x.uuid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_payloadtimecard",
            //    columns: table => new
            //    {
            //        id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        week = table.Column<int>(type: "int", nullable: false),
            //        weekday = table.Column<int>(type: "int", nullable: false),
            //        date_type = table.Column<short>(type: "smallint", nullable: false),
            //        time_table_alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        check_in = table.Column<DateTime>(type: "datetime", nullable: false),
            //        check_out = table.Column<DateTime>(type: "datetime", nullable: false),
            //        work_day = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        clock_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        clock_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        break_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        break_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        lock_down = table.Column<bool>(type: "bit", nullable: false),
            //        present = table.Column<short>(type: "smallint", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        time_table_id = table.Column<int>(type: "int", nullable: true),
            //        full_attendance = table.Column<short>(type: "smallint", nullable: false),
            //        in_trans_id = table.Column<int>(type: "int", nullable: true),
            //        out_trans_id = table.Column<int>(type: "int", nullable: true),
            //        payload = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_payl__3213E83F2C05B8BD", x => x.id);
            //        table.ForeignKey(
            //            name: "att_payloadtimecard_time_table_id_6e0b0137_fk_att_timeinterval_id",
            //            column: x => x.time_table_id,
            //            principalTable: "att_timeinterval",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_reporttemplate",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        report = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        template_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        template_value = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        is_share = table.Column<bool>(type: "bit", nullable: false),
            //        is_auto_export = table.Column<bool>(type: "bit", nullable: false),
            //        fixed_date_period = table.Column<bool>(type: "bit", nullable: false),
            //        language = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        builder_id = table.Column<int>(type: "int", nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_repo__3213E83F3F57B6DB", x => x.id);
            //        table.ForeignKey(
            //            name: "att_reporttemplate_builder_id_e1bb15c6_fk_auth_user_id",
            //            column: x => x.builder_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_temporaryschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        time_interval_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_temp__3213E83FFA4A35FE", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_tempschedule",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        att_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        rule_flag = table.Column<short>(type: "smallint", nullable: false),
            //        work_type = table.Column<short>(type: "smallint", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        time_interval_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_temp__3213E83FCCC163B8", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_training",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        apply_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        attachment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_trai__2F050E153F34CE68", x => x.workflowinstance_ptr_id);
            //        table.ForeignKey(
            //            name: "att_training_pay_code_id_5790afdd_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "att_webpunch",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        work_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        apply_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        verify_type = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__att_webp__2F050E1549E27CA1", x => x.workflowinstance_ptr_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "auth_user_auth_dept",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        myuser_id = table.Column<int>(type: "int", nullable: false),
            //        department_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__auth_use__3213E83F0FCC3D4D", x => x.id);
            //        table.ForeignKey(
            //            name: "auth_user_auth_dept_myuser_id_18a51b27_fk_auth_user_id",
            //            column: x => x.myuser_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "base_linenotifysetting",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        include_sub_department = table.Column<int>(type: "int", nullable: true),
            //        line_notify_token = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        message_type = table.Column<int>(type: "int", nullable: true),
            //        message_head = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        message_tail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        push_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        is_valid = table.Column<int>(type: "int", nullable: true),
            //        remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        line_notify_dept_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__base_lin__3213E83FDF7CF478", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ep_eptransaction",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        emp_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        area = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        check_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        check_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        check_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        temperature = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        is_mask = table.Column<int>(type: "int", nullable: false),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        source = table.Column<short>(type: "smallint", nullable: false),
            //        terminal_sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        emp_id = table.Column<int>(type: "int", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__ep_eptra__3213E83F47AF61F3", x => x.id);
            //        table.ForeignKey(
            //            name: "ep_eptransaction_terminal_id_4490b209_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_biodata",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        bio_tmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        bio_no = table.Column<int>(type: "int", nullable: true),
            //        bio_index = table.Column<int>(type: "int", nullable: true),
            //        bio_type = table.Column<int>(type: "int", nullable: false),
            //        major_ver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        minor_ver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        bio_format = table.Column<int>(type: "int", nullable: true),
            //        valid = table.Column<int>(type: "int", nullable: false),
            //        duress = table.Column<int>(type: "int", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_b__3213E83F07FAF572", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_biophoto",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        first_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
            //        enroll_sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        register_photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        register_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        approval_photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        approval_state = table.Column<short>(type: "smallint", nullable: false),
            //        approval_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_b__3213E83FB3BBB8B0", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_privatemessage",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        last_send = table.Column<DateTime>(type: "datetime", nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        message_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_p__3213E83F599811B7", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_privatemessage_message_id_e3145d3b_fk_iclock_shortmessage_id",
            //            column: x => x.message_id,
            //            principalTable: "iclock_shortmessage",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "iclock_transaction",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        emp_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        verify_type = table.Column<int>(type: "int", nullable: false),
            //        work_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        terminal_sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        terminal_alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        area_alias = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        longitude = table.Column<double>(type: "float", nullable: true),
            //        latitude = table.Column<double>(type: "float", nullable: true),
            //        gps_location = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        source = table.Column<short>(type: "smallint", nullable: true),
            //        purpose = table.Column<short>(type: "smallint", nullable: true),
            //        crc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        is_attendance = table.Column<short>(type: "smallint", nullable: true),
            //        reserved = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sync_status = table.Column<short>(type: "smallint", nullable: true),
            //        sync_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        is_mask = table.Column<short>(type: "smallint", nullable: true),
            //        temperature = table.Column<decimal>(type: "numeric(4,1)", nullable: true),
            //        emp_id = table.Column<int>(type: "int", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: true),
            //        company_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__iclock_t__3213E83F2CDE3856", x => x.id);
            //        table.ForeignKey(
            //            name: "iclock_transaction_terminal_id_451c81c2_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "meeting_meetingentity",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        code = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
            //        alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        meeting_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        in_required = table.Column<bool>(type: "bit", nullable: false),
            //        in_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        in_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        out_required = table.Column<bool>(type: "bit", nullable: false),
            //        out_start = table.Column<DateTime>(type: "datetime", nullable: false),
            //        out_end = table.Column<DateTime>(type: "datetime", nullable: false),
            //        enable_virtual = table.Column<bool>(type: "bit", nullable: false),
            //        virutal_uuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        time_zone = table.Column<short>(type: "smallint", nullable: false),
            //        preferences = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        link_data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        apply_reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        calculation_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sync_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        view_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        host_video = table.Column<bool>(type: "bit", nullable: false),
            //        participant_video = table.Column<bool>(type: "bit", nullable: false),
            //        enable_waiting_room = table.Column<bool>(type: "bit", nullable: false),
            //        jbh_anytime = table.Column<bool>(type: "bit", nullable: false),
            //        mute_upon_entry = table.Column<bool>(type: "bit", nullable: false),
            //        auto_recording = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        room_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__meeting___2F050E15CDD0F5B9", x => x.workflowinstance_ptr_id);
            //        table.ForeignKey(
            //            name: "meeting_meetingentity_room_id_bc2c738e_fk_meeting_meetingroom_id",
            //            column: x => x.room_id,
            //            principalTable: "meeting_meetingroom",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "meeting_meetingentity_attender",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        meetingentity_id = table.Column<int>(type: "int", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__meeting___3213E83F21E1EFE0", x => x.id);
            //        table.ForeignKey(
            //            name: "meeting_meetingentity_attender_meetingentity_id_b96dbc7d_fk_meeting_meetingentity_workflowinstance_ptr_id",
            //            column: x => x.meetingentity_id,
            //            principalTable: "meeting_meetingentity",
            //            principalColumn: "workflowinstance_ptr_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "meeting_meetingmanuallog",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        apply_reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        meeting_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__meeting___2F050E158261B790", x => x.workflowinstance_ptr_id);
            //        table.ForeignKey(
            //            name: "meeting_meetingmanuallog_meeting_id_a672eaaf_fk_meeting_meetingentity_workflowinstance_ptr_id",
            //            column: x => x.meeting_id,
            //            principalTable: "meeting_meetingentity",
            //            principalColumn: "workflowinstance_ptr_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "meeting_meetingpayloadbase",
            //    columns: table => new
            //    {
            //        id = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        duration = table.Column<int>(type: "int", nullable: false),
            //        meeting_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        clock_in = table.Column<DateTime>(type: "datetime", nullable: true),
            //        clock_out = table.Column<DateTime>(type: "datetime", nullable: true),
            //        attended_duration = table.Column<int>(type: "int", nullable: false),
            //        late_in = table.Column<int>(type: "int", nullable: false),
            //        early_out = table.Column<int>(type: "int", nullable: false),
            //        absent = table.Column<int>(type: "int", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: false),
            //        meeting_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__meeting___3213E83FF2494A2E", x => x.id);
            //        table.ForeignKey(
            //            name: "meeting_meetingpayloadbase_meeting_id_ca9d20cc_fk_meeting_meetingentity_workflowinstance_ptr_id",
            //            column: x => x.meeting_id,
            //            principalTable: "meeting_meetingentity",
            //            principalColumn: "workflowinstance_ptr_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "meeting_meetingtransaction",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        emp_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        punch_datetime = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        source = table.Column<short>(type: "smallint", nullable: false),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        emp_id = table.Column<int>(type: "int", nullable: true),
            //        meeting_id = table.Column<int>(type: "int", nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__meeting___3213E83FC5B3660F", x => x.id);
            //        table.ForeignKey(
            //            name: "meeting_meetingtransaction_meeting_id_e4e505e5_fk_meeting_meetingentity_workflowinstance_ptr_id",
            //            column: x => x.meeting_id,
            //            principalTable: "meeting_meetingentity",
            //            principalColumn: "workflowinstance_ptr_id");
            //        table.ForeignKey(
            //            name: "meeting_meetingtransaction_terminal_id_047426f2_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_announcement",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        content = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        category = table.Column<short>(type: "smallint", nullable: false),
            //        sender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        system_sender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        admin_id = table.Column<int>(type: "int", nullable: true),
            //        init_sender_id = table.Column<int>(type: "int", nullable: true),
            //        receiver_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_a__3213E83F3142ABE6", x => x.id);
            //        table.ForeignKey(
            //            name: "mobile_announcement_admin_id_6af3868c_fk_auth_user_id",
            //            column: x => x.admin_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_appnotification",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        sender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        system_sender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        category = table.Column<short>(type: "smallint", nullable: false),
            //        sub_category = table.Column<int>(type: "int", nullable: true),
            //        content = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        payload = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        source = table.Column<int>(type: "int", nullable: true),
            //        notification_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        read_status = table.Column<short>(type: "smallint", nullable: false),
            //        read_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        admin_id = table.Column<int>(type: "int", nullable: true),
            //        init_sender_id = table.Column<int>(type: "int", nullable: true),
            //        receiver_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_a__3213E83F0F8EF721", x => x.id);
            //        table.ForeignKey(
            //            name: "mobile_appnotification_admin_id_29c27197_fk_auth_user_id",
            //            column: x => x.admin_id,
            //            principalTable: "auth_user",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_gpsfordepartment",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        distance = table.Column<int>(type: "int", nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        department_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_g__3213E83F2A79B53C", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_gpsfordepartment_location",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        gpsfordepartment_id = table.Column<int>(type: "int", nullable: false),
            //        gpslocation_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_g__3213E83F33EFA48D", x => x.id);
            //        table.ForeignKey(
            //            name: "mobile_gpsfordepartment_location_gpsfordepartment_id_23e9af3a_fk_mobile_gpsfordepartment_id",
            //            column: x => x.gpsfordepartment_id,
            //            principalTable: "mobile_gpsfordepartment",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "mobile_gpsfordepartment_location_gpslocation_id_48b82e9e_fk_mobile_gpslocation_id",
            //            column: x => x.gpslocation_id,
            //            principalTable: "mobile_gpslocation",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_gpsforemployee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        distance = table.Column<int>(type: "int", nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_g__3213E83FE595D6DC", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_gpsforemployee_location",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        gpsforemployee_id = table.Column<int>(type: "int", nullable: false),
            //        gpslocation_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_g__3213E83F88584C87", x => x.id);
            //        table.ForeignKey(
            //            name: "mobile_gpsforemployee_location_gpsforemployee_id_a52023d5_fk_mobile_gpsforemployee_id",
            //            column: x => x.gpsforemployee_id,
            //            principalTable: "mobile_gpsforemployee",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "mobile_gpsforemployee_location_gpslocation_id_497a214f_fk_mobile_gpslocation_id",
            //            column: x => x.gpslocation_id,
            //            principalTable: "mobile_gpslocation",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "mobile_mobileapirequestlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        username_persistent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        requested_at = table.Column<DateTime>(type: "datetime", nullable: false),
            //        response_ms = table.Column<int>(type: "int", nullable: false),
            //        path = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        view = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        view_method = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        remote_addr = table.Column<string>(type: "nvarchar(39)", maxLength: 39, nullable: false),
            //        host = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        method = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
            //        query_params = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        data = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        response = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        errors = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        status_code = table.Column<int>(type: "int", nullable: true),
            //        user_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__mobile_m__3213E83F0A041432", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_emploan",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        loan_amount = table.Column<double>(type: "float", nullable: false),
            //        loan_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        refund_cycle = table.Column<short>(type: "smallint", nullable: false),
            //        per_cycle_refund = table.Column<double>(type: "float", nullable: false),
            //        loan_clean_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        remark = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F9F678CCB", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_emppayrollprofile",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        payment_mode = table.Column<short>(type: "smallint", nullable: true),
            //        payment_type = table.Column<short>(type: "smallint", nullable: true),
            //        bank_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        bank_account = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        personnel_id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        agent_id = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        agent_account = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83FD55FEFF9", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_extradeduction",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        amount = table.Column<double>(type: "float", nullable: false),
            //        issued_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F0A966DE0", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_extraincrease",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        amount = table.Column<double>(type: "float", nullable: false),
            //        issued_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        remark = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F13014BBC", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_payrollpayload",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        calc_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        basic_salary = table.Column<double>(type: "float", nullable: true),
            //        effective_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        format_dict = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        payment_mode = table.Column<short>(type: "smallint", nullable: true),
            //        increase = table.Column<double>(type: "float", nullable: true),
            //        deduction = table.Column<double>(type: "float", nullable: true),
            //        increase_formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        deduction_formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        increase_formula_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        deduction_formula_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        extra_increase = table.Column<double>(type: "float", nullable: true),
            //        extra_deduction = table.Column<double>(type: "float", nullable: true),
            //        total_loan_amount = table.Column<double>(type: "float", nullable: true),
            //        refund_loan_amount = table.Column<double>(type: "float", nullable: true),
            //        unrefund_loan_amount = table.Column<double>(type: "float", nullable: true),
            //        loan_deduction = table.Column<double>(type: "float", nullable: true),
            //        loan_increase = table.Column<double>(type: "float", nullable: true),
            //        advance_increase = table.Column<double>(type: "float", nullable: true),
            //        advance_deduction = table.Column<double>(type: "float", nullable: true),
            //        reimbursement = table.Column<double>(type: "float", nullable: true),
            //        total_increase_formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        total_increase_formula_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        total_increase_expression = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        total_increase = table.Column<double>(type: "float", nullable: true),
            //        total_deduction_formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        total_deduction_formula_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        total_deduction_expression = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        total_deduction = table.Column<double>(type: "float", nullable: true),
            //        total_salary_expression = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        total_salary = table.Column<double>(type: "float", nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83FBFDBA211", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_payrollpayloadpaycode",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        amount = table.Column<double>(type: "float", nullable: true),
            //        formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        formula_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        pay_code_id = table.Column<int>(type: "int", nullable: false),
            //        payload_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F311397FC", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_payrollpayloadpaycode_pay_code_id_c057af1f_fk_att_paycode_id",
            //            column: x => x.pay_code_id,
            //            principalTable: "att_paycode",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "payroll_payrollpayloadpaycode_payload_id_f085c4e8_fk_payroll_payrollpayload_id",
            //            column: x => x.payload_id,
            //            principalTable: "payroll_payrollpayload",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_reimbursement",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        rmb_amount = table.Column<double>(type: "float", nullable: false),
            //        rmb_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        rmb_file = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        rmb_remark = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F26ABA7CB", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_salaryadvance",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        advance_amount = table.Column<double>(type: "float", nullable: false),
            //        advance_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        advance_remark = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F95B5E63B", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_salarystructure",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        salary_amount = table.Column<double>(type: "float", nullable: false),
            //        effective_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        salary_remark = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F9AE366AD", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_salarystructure_deductionformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        salarystructure_id = table.Column<int>(type: "int", nullable: false),
            //        deductionformula_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83FE7D44BE9", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_deductionformula_deductionformula_id_b174d5b6_fk_payroll_deductionformula_id",
            //            column: x => x.deductionformula_id,
            //            principalTable: "payroll_deductionformula",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_deductionformula_salarystructure_id_5ca7cdb5_fk_payroll_salarystructure_id",
            //            column: x => x.salarystructure_id,
            //            principalTable: "payroll_salarystructure",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_salarystructure_exceptionformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        salarystructure_id = table.Column<int>(type: "int", nullable: false),
            //        exceptionformula_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F244AB5D1", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_exceptionformula_exceptionformula_id_8f6dadb3_fk_payroll_exceptionformula_id",
            //            column: x => x.exceptionformula_id,
            //            principalTable: "payroll_exceptionformula",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_exceptionformula_salarystructure_id_3c087208_fk_payroll_salarystructure_id",
            //            column: x => x.salarystructure_id,
            //            principalTable: "payroll_salarystructure",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_salarystructure_increasementformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        salarystructure_id = table.Column<int>(type: "int", nullable: false),
            //        increasementformula_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F7359F3AC", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_increasementformula_increasementformula_id_3cd77082_fk_payroll_increasementformula_id",
            //            column: x => x.increasementformula_id,
            //            principalTable: "payroll_increasementformula",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_increasementformula_salarystructure_id_8752401c_fk_payroll_salarystructure_id",
            //            column: x => x.salarystructure_id,
            //            principalTable: "payroll_salarystructure",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_salarystructure_leaveformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        salarystructure_id = table.Column<int>(type: "int", nullable: false),
            //        leaveformula_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83F4203811D", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_leaveformula_leaveformula_id_049f9024_fk_payroll_leaveformula_id",
            //            column: x => x.leaveformula_id,
            //            principalTable: "payroll_leaveformula",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_leaveformula_salarystructure_id_cf98fdd7_fk_payroll_salarystructure_id",
            //            column: x => x.salarystructure_id,
            //            principalTable: "payroll_salarystructure",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "payroll_salarystructure_overtimeformula",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        salarystructure_id = table.Column<int>(type: "int", nullable: false),
            //        overtimeformula_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__payroll___3213E83FD41F71ED", x => x.id);
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_overtimeformula_overtimeformula_id_40ad89ef_fk_payroll_overtimeformula_id",
            //            column: x => x.overtimeformula_id,
            //            principalTable: "payroll_overtimeformula",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "payroll_salarystructure_overtimeformula_salarystructure_id_64f75042_fk_payroll_salarystructure_id",
            //            column: x => x.salarystructure_id,
            //            principalTable: "payroll_salarystructure",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_assignareaemployee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        assigned_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        area_id = table.Column<int>(type: "int", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F76866BE3", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_assignareaemployee_area_id_6f049d6a_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_department",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        dept_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        dept_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        is_default = table.Column<bool>(type: "bit", nullable: false),
            //        parent_dept_id = table.Column<int>(type: "int", nullable: true),
            //        dept_manager_id = table.Column<int>(type: "int", nullable: true),
            //        company_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F83B5FF74", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_department_company_id_00867fd8_fk_personnel_company_id",
            //            column: x => x.company_id,
            //            principalTable: "personnel_company",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_department_parent_dept_id_d0b44024_fk_personnel_department_id",
            //            column: x => x.parent_dept_id,
            //            principalTable: "personnel_department",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        device_password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        dev_privilege = table.Column<int>(type: "int", nullable: true),
            //        card_no = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        acc_group = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        acc_timezone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        enroll_sn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        verify_mode = table.Column<int>(type: "int", nullable: true),
            //        app_status = table.Column<short>(type: "smallint", nullable: true),
            //        app_role = table.Column<short>(type: "smallint", nullable: true),
            //        last_login = table.Column<DateTime>(type: "datetime", nullable: true),
            //        is_active = table.Column<bool>(type: "bit", nullable: false),
            //        session_key = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //        login_ip = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
            //        emp_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        first_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        nickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        passport = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        driver_license_automobile = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        driver_license_motorcycle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        self_password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
            //        gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
            //        birthday = table.Column<DateTime>(type: "datetime", nullable: true),
            //        address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        postcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        office_tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        contact_tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        national = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        religion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        ssn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        hire_date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        city = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        emp_type = table.Column<short>(type: "smallint", nullable: true),
            //        enable_payroll = table.Column<bool>(type: "bit", nullable: false),
            //        email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        leave_group = table.Column<int>(type: "int", nullable: true),
            //        department_id = table.Column<int>(type: "int", nullable: true),
            //        position_id = table.Column<int>(type: "int", nullable: true),
            //        emp_code_digit = table.Column<long>(type: "bigint", nullable: true),
            //        superior_id = table.Column<int>(type: "int", nullable: true),
            //        company_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F6F406DC8", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employee_company_id_95b3fd72_fk_personnel_company_id",
            //            column: x => x.company_id,
            //            principalTable: "personnel_company",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_employee_department_id_068bbd08_fk_personnel_department_id",
            //            column: x => x.department_id,
            //            principalTable: "personnel_department",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_employee_position_id_c9321343_fk_personnel_position_id",
            //            column: x => x.position_id,
            //            principalTable: "personnel_position",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_employee_superior_id_ad6e1c47_fk_personnel_employee_id",
            //            column: x => x.superior_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_workflowengine",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        workflow_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        workflow_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        workflow_type = table.Column<short>(type: "smallint", nullable: false),
            //        applicant_position_id = table.Column<int>(type: "int", nullable: true),
            //        content_type_id = table.Column<int>(type: "int", nullable: true),
            //        departments_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83FDBB68F56", x => x.id);
            //        table.ForeignKey(
            //            name: "workflow_workflowengine_applicant_position_id_8a65e03a_fk_personnel_position_id",
            //            column: x => x.applicant_position_id,
            //            principalTable: "personnel_position",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_workflowengine_content_type_id_f7345c20_fk_django_content_type_id",
            //            column: x => x.content_type_id,
            //            principalTable: "django_content_type",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_workflowengine_departments_id_0f06d4c7_fk_personnel_department_id",
            //            column: x => x.departments_id,
            //            principalTable: "personnel_department",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employee_area",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        area_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83FFE9CEFC5", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employee_area_area_id_64c21925_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_employee_area_employee_id_8e5cec21_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employee_flow_role",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        workflowrole_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83FA6FF5C15", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employee_flow_role_employee_id_c27f8a56_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_employee_flow_role_workflowrole_id_4704db32_fk_workflow_workflowrole_id",
            //            column: x => x.workflowrole_id,
            //            principalTable: "workflow_workflowrole",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employeecalendar",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        calendar = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F2BDEA0C4", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employeecalendar_employee_id_165e0779_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employeecertification",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        expire_on = table.Column<DateTime>(type: "datetime", nullable: true),
            //        email_alert = table.Column<bool>(type: "bit", nullable: false),
            //        before = table.Column<int>(type: "int", nullable: true),
            //        certification_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        file_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        file = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        certification_id = table.Column<int>(type: "int", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83FF793560C", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employeecertification_certification_id_faabed40_fk_personnel_certification_id",
            //            column: x => x.certification_id,
            //            principalTable: "personnel_certification",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "personnel_employeecertification_employee_id_b7bd3867_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employeeextrainfo",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        value = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83FDA2E67B1", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employeeextrainfo_employee_id_41e2b04d_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employeeprofile",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        column_order = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        disabled_fields = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        preferences = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        pwd_update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        emp_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F16EABD7F", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employeeprofile_emp_id_3a69c313_fk_personnel_employee_id",
            //            column: x => x.emp_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_employment",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        employment_type = table.Column<short>(type: "smallint", nullable: false),
            //        start_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        active_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        inactive_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F38D39A18", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_employment_employee_id_f797c7d9_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "personnel_resign",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        resign_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        resign_type = table.Column<int>(type: "int", nullable: true),
            //        disableatt = table.Column<bool>(type: "bit", nullable: false),
            //        reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__personne__3213E83F92EC79B7", x => x.id);
            //        table.ForeignKey(
            //            name: "personnel_resign_employee_id_dd9b7e08_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "staff_stafftoken",
            //    columns: table => new
            //    {
            //        key = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        created = table.Column<DateTime>(type: "datetime", nullable: false),
            //        user_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__staff_st__DFD83CAE2FED8D30", x => x.key);
            //        table.ForeignKey(
            //            name: "staff_stafftoken_user_id_39c937fa_fk_personnel_employee_id",
            //            column: x => x.user_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitor",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        visitor_code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        first_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        last_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        cert_no = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        card_no = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
            //        company = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        ssn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        visit_quantity = table.Column<int>(type: "int", nullable: false),
            //        entry_carrying_goods = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        start_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        end_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        exit_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        exit_carrying_goods = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        cert_type_id = table.Column<int>(type: "int", nullable: false),
            //        visit_department_id = table.Column<int>(type: "int", nullable: true),
            //        visit_reason_id = table.Column<int>(type: "int", nullable: true),
            //        visited_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83F0EB5C26D", x => x.id);
            //        table.ForeignKey(
            //            name: "visitor_visitor_cert_type_id_f62ea604_fk_personnel_certification_id",
            //            column: x => x.cert_type_id,
            //            principalTable: "personnel_certification",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_visitor_visit_department_id_f7dbdcb4_fk_personnel_department_id",
            //            column: x => x.visit_department_id,
            //            principalTable: "personnel_department",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_visitor_visit_reason_id_4b9a2d23_fk_visitor_reason_id",
            //            column: x => x.visit_reason_id,
            //            principalTable: "visitor_reason",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_visitor_visited_id_8043a7ea_fk_personnel_employee_id",
            //            column: x => x.visited_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_workflowengine_employee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        workflowengine_id = table.Column<int>(type: "int", nullable: false),
            //        employee_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83F4CAF9BE6", x => x.id);
            //        table.ForeignKey(
            //            name: "workflow_workflowengine_employee_employee_id_803a409e_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_workflowengine_employee_workflowengine_id_6ebcc5f2_fk_workflow_workflowengine_id",
            //            column: x => x.workflowengine_id,
            //            principalTable: "workflow_workflowengine",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_workflowinstance",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        approval_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        approval_status = table.Column<short>(type: "smallint", nullable: false),
            //        approval_remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        approver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        approver_instance = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        employee_id = table.Column<int>(type: "int", nullable: false),
            //        workflow_engine_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83FF2E66249", x => x.id);
            //        table.ForeignKey(
            //            name: "workflow_workflowinstance_employee_id_c7cff08e_fk_personnel_employee_id",
            //            column: x => x.employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_workflowinstance_workflow_engine_id_1e6ac40f_fk_workflow_workflowengine_id",
            //            column: x => x.workflow_engine_id,
            //            principalTable: "workflow_workflowengine",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_workflownode",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        node_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        order_id = table.Column<int>(type: "int", nullable: false),
            //        approver_by_overall = table.Column<bool>(type: "bit", nullable: false),
            //        notify_by_overall = table.Column<bool>(type: "bit", nullable: false),
            //        workflow_engine_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83F48B0A80A", x => x.id);
            //        table.ForeignKey(
            //            name: "workflow_workflownode_workflow_engine_id_04c8f470_fk_workflow_workflowengine_id",
            //            column: x => x.workflow_engine_id,
            //            principalTable: "workflow_workflowengine",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitor_acc_groups",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        visitor_id = table.Column<int>(type: "int", nullable: false),
            //        accgroups_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83FF93EB829", x => x.id);
            //        table.ForeignKey(
            //            name: "visitor_visitor_acc_groups_accgroups_id_b1487149_fk_acc_accgroups_id",
            //            column: x => x.accgroups_id,
            //            principalTable: "acc_accgroups",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_visitor_acc_groups_visitor_id_8ce09562_fk_visitor_visitor_id",
            //            column: x => x.visitor_id,
            //            principalTable: "visitor_visitor",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitor_area",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        visitor_id = table.Column<int>(type: "int", nullable: false),
            //        area_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83F73FBF0DE", x => x.id);
            //        table.ForeignKey(
            //            name: "visitor_visitor_area_area_id_b402c047_fk_personnel_area_id",
            //            column: x => x.area_id,
            //            principalTable: "personnel_area",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_visitor_area_visitor_id_98d7ed05_fk_visitor_visitor_id",
            //            column: x => x.visitor_id,
            //            principalTable: "visitor_visitor",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitorbiodata",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        bio_tmp = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        bio_no = table.Column<int>(type: "int", nullable: true),
            //        bio_index = table.Column<int>(type: "int", nullable: true),
            //        bio_type = table.Column<int>(type: "int", nullable: false),
            //        major_ver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        minor_ver = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        bio_format = table.Column<int>(type: "int", nullable: true),
            //        valid = table.Column<int>(type: "int", nullable: false),
            //        duress = table.Column<int>(type: "int", nullable: false),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        visitor_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83F718A1ADA", x => x.id);
            //        table.ForeignKey(
            //            name: "visitor_visitorbiodata_visitor_id_b944ed37_fk_visitor_visitor_id",
            //            column: x => x.visitor_id,
            //            principalTable: "visitor_visitor",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitorbiophoto",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        first_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
            //        enroll_sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        register_photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        register_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        approval_photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        approval_state = table.Column<short>(type: "smallint", nullable: false),
            //        approval_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        remark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        visitor_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83F3A5CFA8C", x => x.id);
            //        table.ForeignKey(
            //            name: "visitor_visitorbiophoto_visitor_id_9816daf7_fk_visitor_visitor_id",
            //            column: x => x.visitor_id,
            //            principalTable: "visitor_visitor",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitorlog",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        visitor_status = table.Column<short>(type: "smallint", nullable: true),
            //        visitor_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83FBAC6E6D6", x => x.id);
            //        table.ForeignKey(
            //            name: "visitor_visitorlog_visitor_id_ebaafde1_fk_visitor_visitor_id",
            //            column: x => x.visitor_id,
            //            principalTable: "visitor_visitor",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_visitortransaction",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        create_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        create_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        change_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        change_user = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        status = table.Column<short>(type: "smallint", nullable: false),
            //        visitor_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        area = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        punch_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        punch_state = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
            //        verify_type = table.Column<int>(type: "int", nullable: false),
            //        temperature = table.Column<decimal>(type: "numeric(4,1)", nullable: false),
            //        is_mask = table.Column<int>(type: "int", nullable: false),
            //        upload_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        source = table.Column<short>(type: "smallint", nullable: false),
            //        terminal_sn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        terminal_alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        terminal_id = table.Column<int>(type: "int", nullable: true),
            //        visitor_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___3213E83F0798A5D8", x => x.id);
            //        table.ForeignKey(
            //            name: "visitor_visitortransaction_terminal_id_7527ef69_fk_iclock_terminal_id",
            //            column: x => x.terminal_id,
            //            principalTable: "iclock_terminal",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_visitortransaction_visitor_id_0ee95624_fk_visitor_visitor_id",
            //            column: x => x.visitor_id,
            //            principalTable: "visitor_visitor",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "visitor_reservation",
            //    columns: table => new
            //    {
            //        workflowinstance_ptr_id = table.Column<int>(type: "int", nullable: false),
            //        vis_first_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        vis_last_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        cert_no = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
            //        company = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        update_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        visit_quantity = table.Column<int>(type: "int", nullable: false),
            //        visit_date = table.Column<DateTime>(type: "datetime", nullable: false),
            //        apply_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        apply_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        cert_type_id = table.Column<int>(type: "int", nullable: false),
            //        visit_department_id = table.Column<int>(type: "int", nullable: true),
            //        visit_reason_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__visitor___2F050E153093B5F4", x => x.workflowinstance_ptr_id);
            //        table.ForeignKey(
            //            name: "visitor_reservation_cert_type_id_4f047f2a_fk_personnel_certification_id",
            //            column: x => x.cert_type_id,
            //            principalTable: "personnel_certification",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_reservation_visit_department_id_2d293e10_fk_personnel_department_id",
            //            column: x => x.visit_department_id,
            //            principalTable: "personnel_department",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_reservation_visit_reason_id_c9ac83ac_fk_visitor_reason_id",
            //            column: x => x.visit_reason_id,
            //            principalTable: "visitor_reason",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "visitor_reservation_workflowinstance_ptr_id_3787bcd6_fk_workflow_workflowinstance_id",
            //            column: x => x.workflowinstance_ptr_id,
            //            principalTable: "workflow_workflowinstance",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_nodeinstance",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        node_name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        order_id = table.Column<int>(type: "int", nullable: false),
            //        approval_status = table.Column<short>(type: "smallint", nullable: false),
            //        approval_time = table.Column<DateTime>(type: "datetime", nullable: true),
            //        approval_remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        active = table.Column<bool>(type: "bit", nullable: false),
            //        targeted = table.Column<bool>(type: "bit", nullable: false),
            //        approver_employee_id = table.Column<int>(type: "int", nullable: true),
            //        workflow_instance_id = table.Column<int>(type: "int", nullable: true),
            //        workflow_node_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83F1E3CE5E2", x => x.id);
            //        table.ForeignKey(
            //            name: "workflow_nodeinstance_approver_employee_id_d36cd45d_fk_personnel_employee_id",
            //            column: x => x.approver_employee_id,
            //            principalTable: "personnel_employee",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_nodeinstance_workflow_instance_id_afe84fe4_fk_workflow_workflowinstance_id",
            //            column: x => x.workflow_instance_id,
            //            principalTable: "workflow_workflowinstance",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_nodeinstance_workflow_node_id_166f36c4_fk_workflow_workflownode_id",
            //            column: x => x.workflow_node_id,
            //            principalTable: "workflow_workflownode",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_workflownode_approver",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        workflownode_id = table.Column<int>(type: "int", nullable: false),
            //        workflowrole_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83F69FE0B97", x => x.id);
            //        table.ForeignKey(
            //            name: "workflow_workflownode_approver_workflownode_id_d814c941_fk_workflow_workflownode_id",
            //            column: x => x.workflownode_id,
            //            principalTable: "workflow_workflownode",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_workflownode_approver_workflowrole_id_c8e00d42_fk_workflow_workflowrole_id",
            //            column: x => x.workflowrole_id,
            //            principalTable: "workflow_workflowrole",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "workflow_workflownode_notifier",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        workflownode_id = table.Column<int>(type: "int", nullable: false),
            //        workflowrole_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__workflow__3213E83FDAFA86CF", x => x.id);
            //        table.ForeignKey(
            //            name: "workflow_workflownode_notifier_workflownode_id_57298016_fk_workflow_workflownode_id",
            //            column: x => x.workflownode_id,
            //            principalTable: "workflow_workflownode",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "workflow_workflownode_notifier_workflowrole_id_73de7fc2_fk_workflow_workflowrole_id",
            //            column: x => x.workflowrole_id,
            //            principalTable: "workflow_workflowrole",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "acc_acccombination_area_id_0d22c34e",
            //    table: "acc_acccombination",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_acccombination_area_id_combination_no_619eb4f5_uniq",
            //    table: "acc_acccombination",
            //    columns: new[] { "area_id", "combination_no" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "acc_accgroups_area_id_b83745c3",
            //    table: "acc_accgroups",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_accgroups_area_id_group_no_5130a89c_uniq",
            //    table: "acc_accgroups",
            //    columns: new[] { "area_id", "group_no" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "acc_accholiday_area_id_d15c19da",
            //    table: "acc_accholiday",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_accholiday_area_id_holiday_id_6630c2eb_uniq",
            //    table: "acc_accholiday",
            //    columns: new[] { "area_id", "holiday_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "acc_accholiday_holiday_id_a9efe924",
            //    table: "acc_accholiday",
            //    column: "holiday_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_accholiday_timezone_id_450d2d1e",
            //    table: "acc_accholiday",
            //    column: "timezone_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_accprivilege_area_id_2123ff6f",
            //    table: "acc_accprivilege",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_accprivilege_area_id_employee_id_group_id_f3b297d8_uniq",
            //    table: "acc_accprivilege",
            //    columns: new[] { "area_id", "employee_id", "group_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "acc_accprivilege_employee_id_5fc55f95",
            //    table: "acc_accprivilege",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_accprivilege_group_id_c5ed7003",
            //    table: "acc_accprivilege",
            //    column: "group_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_accterminal_terminal_id_fc92cce2",
            //    table: "acc_accterminal",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_acctimezone_area_id_e9ce7a7a",
            //    table: "acc_acctimezone",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "acc_acctimezone_area_id_timezone_no_0cb8250f_uniq",
            //    table: "acc_acctimezone",
            //    columns: new[] { "area_id", "timezone_no" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "accounts_adminbiodata_admin_id_1e6d2d45",
            //    table: "accounts_adminbiodata",
            //    column: "admin_id");

            //migrationBuilder.CreateIndex(
            //    name: "accounts_usernotification_user_id_b86755b3",
            //    table: "accounts_usernotification",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_attc__357D4CF908B7FF93",
            //    table: "att_attcode",
            //    column: "code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_attc__8C585C04E7B32BF3",
            //    table: "att_attcode",
            //    column: "alias",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "att_attemployee_group_id_18d3954d",
            //    table: "att_attemployee",
            //    column: "group_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_atte__1299A860D6C9D2DE",
            //    table: "att_attemployee",
            //    column: "emp_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_attg__357D4CF9C95C4E5F",
            //    table: "att_attgroup",
            //    column: "code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_attg__72E12F1BB24AE63C",
            //    table: "att_attgroup",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "att_attpolicy_ot_pay_code_id_b189b952",
            //    table: "att_attpolicy",
            //    column: "ot_pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_attschedule_employee_id_caa61686",
            //    table: "att_attschedule",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_attschedule_shift_id_13d2db9a",
            //    table: "att_attschedule",
            //    column: "shift_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_breaktime_alias_6212d9cf_uniq",
            //    table: "att_breaktime",
            //    column: "alias",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "att_breaktime_loss_code_id_2ffb5432",
            //    table: "att_breaktime",
            //    column: "loss_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_breaktime_profit_code_id_63cdbbcc",
            //    table: "att_breaktime",
            //    column: "profit_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_calculatelastdate_last_date_1441abdc",
            //    table: "att_calculatelastdate",
            //    column: "last_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_calculatetask_end_date_75d1d6d2",
            //    table: "att_calculatetask",
            //    column: "end_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_calculatetask_start_date_7bbaa889",
            //    table: "att_calculatetask",
            //    column: "start_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_changeschedule_timeinterval_id_d41ac077",
            //    table: "att_changeschedule",
            //    column: "timeinterval_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_departmentpolicy_department_id_77059a9d",
            //    table: "att_departmentpolicy",
            //    column: "department_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_departmentpolicy_ot_pay_code_id_390411dd",
            //    table: "att_departmentpolicy",
            //    column: "ot_pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_departmentschedule_department_id_c68fca3d",
            //    table: "att_departmentschedule",
            //    column: "department_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_departmentschedule_shift_id_c37d5ade",
            //    table: "att_departmentschedule",
            //    column: "shift_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_deptattrule_department_id_f333c8f0",
            //    table: "att_deptattrule",
            //    column: "department_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_grouppolicy_group_id_b2e4dfe8",
            //    table: "att_grouppolicy",
            //    column: "group_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_grouppolicy_ot_pay_code_id_1ec83080",
            //    table: "att_grouppolicy",
            //    column: "ot_pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_groupschedule_group_id_c341493f",
            //    table: "att_groupschedule",
            //    column: "group_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_groupschedule_shift_id_287e7fc0",
            //    table: "att_groupschedule",
            //    column: "shift_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_groupschedule_start_date_638b6d85",
            //    table: "att_groupschedule",
            //    column: "start_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_holiday_att_group_id_9ddf13ba",
            //    table: "att_holiday",
            //    column: "att_group_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_holiday_department_id_fbbbd185",
            //    table: "att_holiday",
            //    column: "department_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_leave_pay_code_id_2fadf493",
            //    table: "att_leave",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_leav__357D4CF9FB952B1D",
            //    table: "att_leavegroup",
            //    column: "code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_leav__72E12F1BD8793500",
            //    table: "att_leavegroup",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "att_leavegroupdetail_leave_group_id_28f69ada",
            //    table: "att_leavegroupdetail",
            //    column: "leave_group_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_leavegroupdetail_pay_code_id_5013b373",
            //    table: "att_leavegroupdetail",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_leaveyearbalance_employee_id_14febdb3",
            //    table: "att_leaveyearbalance",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_leaveyearbalance_employee_id_year_pay_code_id_2ec71517_uniq",
            //    table: "att_leaveyearbalance",
            //    columns: new[] { "employee_id", "year", "pay_code_id" },
            //    unique: true,
            //    filter: "[year] IS NOT NULL AND [pay_code_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "att_leaveyearbalance_pay_code_id_82632aca",
            //    table: "att_leaveyearbalance",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_overtime_pay_code_id_05600ee0",
            //    table: "att_overtime",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_overtimepolicy_overnight_pay_code_id_274ce1b0",
            //    table: "att_overtimepolicy",
            //    column: "overnight_pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_overtimepolicy_pay_code_id_285b0a61",
            //    table: "att_overtimepolicy",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_payc__357D4CF91081334D",
            //    table: "att_paycode",
            //    column: "code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_payc__72E12F1B9F403A95",
            //    table: "att_paycode",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadattcode_att_code_id_0d635efd",
            //    table: "att_payloadattcode",
            //    column: "att_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadattcode_att_date_19b2621e",
            //    table: "att_payloadattcode",
            //    column: "att_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadattcode_emp_id_36569f54",
            //    table: "att_payloadattcode",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadattcode_shift_id_731faddf",
            //    table: "att_payloadattcode",
            //    column: "shift_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadattcode_time_card_id_e8a37c7a",
            //    table: "att_payloadattcode",
            //    column: "time_card_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadbase_emp_id_2c0f6a7b",
            //    table: "att_payloadbase",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadbase_timetable_id_a389e3d8",
            //    table: "att_payloadbase",
            //    column: "timetable_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_payl__3C490B12E7CF450E",
            //    table: "att_payloadbase",
            //    column: "break_time_id",
            //    unique: true,
            //    filter: "[break_time_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_payl__B846E81054776BB4",
            //    table: "att_payloadbase",
            //    column: "overtime_id",
            //    unique: true,
            //    filter: "[overtime_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadeffectpunch_att_date_1e3de2d4",
            //    table: "att_payloadeffectpunch",
            //    column: "att_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadeffectpunch_emp_id_67e28e01",
            //    table: "att_payloadeffectpunch",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadeffectpunch_time_card_id_52f69aaf",
            //    table: "att_payloadeffectpunch",
            //    column: "time_card_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadeffectpunch_trans_id_94affbe6",
            //    table: "att_payloadeffectpunch",
            //    column: "trans_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadexception_item_id_a08bfe48",
            //    table: "att_payloadexception",
            //    column: "item_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadexception_skd_id_b2e9ecaa",
            //    table: "att_payloadexception",
            //    column: "skd_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadmulpunchset_emp_id_f47610c8",
            //    table: "att_payloadmulpunchset",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadmulpunchset_timetable_id_9a439a09",
            //    table: "att_payloadmulpunchset",
            //    column: "timetable_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadparing_att_date_5daaa45d",
            //    table: "att_payloadparing",
            //    column: "att_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadparing_emp_id_c5daac4f",
            //    table: "att_payloadparing",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadparing_in_trans_id_50a8040e",
            //    table: "att_payloadparing",
            //    column: "in_trans_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadparing_out_trans_id_8b2375b9",
            //    table: "att_payloadparing",
            //    column: "out_trans_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadparing_pay_code_id_aa241cca",
            //    table: "att_payloadparing",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadparing_time_card_id_3adc3517",
            //    table: "att_payloadparing",
            //    column: "time_card_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpaycode_att_date_aa048d7b",
            //    table: "att_payloadpaycode",
            //    column: "att_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpaycode_emp_id_78e75279",
            //    table: "att_payloadpaycode",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpaycode_pay_code_id_4a096cc7",
            //    table: "att_payloadpaycode",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpaycode_shift_id_79a0901e",
            //    table: "att_payloadpaycode",
            //    column: "shift_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpaycode_time_card_id_1696b969",
            //    table: "att_payloadpaycode",
            //    column: "time_card_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpunch_emp_id_053da2f0",
            //    table: "att_payloadpunch",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpunch_orig_id_16b26416",
            //    table: "att_payloadpunch",
            //    column: "orig_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadpunch_skd_id_17596d82",
            //    table: "att_payloadpunch",
            //    column: "skd_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadtimecard_att_date_48c1dc00",
            //    table: "att_payloadtimecard",
            //    column: "att_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadtimecard_emp_id_47caeab4",
            //    table: "att_payloadtimecard",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadtimecard_emp_id_att_date_time_table_id_9df16bc5_uniq",
            //    table: "att_payloadtimecard",
            //    columns: new[] { "emp_id", "att_date", "time_table_id" },
            //    unique: true,
            //    filter: "[time_table_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadtimecard_in_trans_id_d0e9c411",
            //    table: "att_payloadtimecard",
            //    column: "in_trans_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadtimecard_out_trans_id_aff7023d",
            //    table: "att_payloadtimecard",
            //    column: "out_trans_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_payloadtimecard_time_table_id_6e0b0137",
            //    table: "att_payloadtimecard",
            //    column: "time_table_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_reporttemplate_builder_id_e1bb15c6",
            //    table: "att_reporttemplate",
            //    column: "builder_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_reporttemplate_employee_id_4f80d866",
            //    table: "att_reporttemplate",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_shiftdetail_shift_id_7d694501",
            //    table: "att_shiftdetail",
            //    column: "shift_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_shiftdetail_time_interval_id_777dde8f",
            //    table: "att_shiftdetail",
            //    column: "time_interval_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_temporaryschedule_att_date_8aed8916",
            //    table: "att_temporaryschedule",
            //    column: "att_date");

            //migrationBuilder.CreateIndex(
            //    name: "att_temporaryschedule_employee_id_2b2b94c2",
            //    table: "att_temporaryschedule",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_temporaryschedule_time_interval_id_2be60ee4",
            //    table: "att_temporaryschedule",
            //    column: "time_interval_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_tempschedule_employee_id_b89c7e54",
            //    table: "att_tempschedule",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_tempschedule_time_interval_id_08dd8eb3",
            //    table: "att_tempschedule",
            //    column: "time_interval_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_timeinterval_ot_pay_code_id_17438af8",
            //    table: "att_timeinterval",
            //    column: "ot_pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__att_time__8C585C0478C04259",
            //    table: "att_timeinterval",
            //    column: "alias",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "att_timeinterval_break_time_breaktime_id_08462308",
            //    table: "att_timeinterval_break_time",
            //    column: "breaktime_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_timeinterval_break_time_timeinterval_id_2287017e",
            //    table: "att_timeinterval_break_time",
            //    column: "timeinterval_id");

            //migrationBuilder.CreateIndex(
            //    name: "att_timeinterval_break_time_timeinterval_id_breaktime_id_6e1bfb4e_uniq",
            //    table: "att_timeinterval_break_time",
            //    columns: new[] { "timeinterval_id", "breaktime_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "att_training_pay_code_id_5790afdd",
            //    table: "att_training",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "attparam_paraname_paratype_6f176d25_uniq",
            //    table: "attparam",
            //    columns: new[] { "paraname", "paratype" },
            //    unique: true,
            //    filter: "[paratype] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__auth_gro__72E12F1BA40B0CC7",
            //    table: "auth_group",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "auth_group_permissions_group_id_b120cbf9",
            //    table: "auth_group_permissions",
            //    column: "group_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_group_permissions_group_id_permission_id_0cd325b0_uniq",
            //    table: "auth_group_permissions",
            //    columns: new[] { "group_id", "permission_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "auth_group_permissions_permission_id_84c5c92e",
            //    table: "auth_group_permissions",
            //    column: "permission_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_permission_content_type_id_2f476e4b",
            //    table: "auth_permission",
            //    column: "content_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_permission_content_type_id_codename_01ab375a_uniq",
            //    table: "auth_permission",
            //    columns: new[] { "content_type_id", "codename" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__auth_use__F3DBC57244641B31",
            //    table: "auth_user",
            //    column: "username",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_auth_area_area_id_d1e54c70",
            //    table: "auth_user_auth_area",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_auth_area_myuser_id_5fb9a803",
            //    table: "auth_user_auth_area",
            //    column: "myuser_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_auth_area_myuser_id_area_id_02a19d63_uniq",
            //    table: "auth_user_auth_area",
            //    columns: new[] { "myuser_id", "area_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_auth_dept_department_id_5866c514",
            //    table: "auth_user_auth_dept",
            //    column: "department_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_auth_dept_myuser_id_18a51b27",
            //    table: "auth_user_auth_dept",
            //    column: "myuser_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_auth_dept_myuser_id_department_id_61d83386_uniq",
            //    table: "auth_user_auth_dept",
            //    columns: new[] { "myuser_id", "department_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_groups_group_id_97559544",
            //    table: "auth_user_groups",
            //    column: "group_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_groups_myuser_id_d03e8dcc",
            //    table: "auth_user_groups",
            //    column: "myuser_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_groups_myuser_id_group_id_664bdfc3_uniq",
            //    table: "auth_user_groups",
            //    columns: new[] { "myuser_id", "group_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__auth_use__B9BE370EADB74DF7",
            //    table: "auth_user_profile",
            //    column: "user_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_user_permissions_myuser_id_679b1527",
            //    table: "auth_user_user_permissions",
            //    column: "myuser_id");

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_user_permissions_myuser_id_permission_id_a558717f_uniq",
            //    table: "auth_user_user_permissions",
            //    columns: new[] { "myuser_id", "permission_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "auth_user_user_permissions_permission_id_1fbb5f2c",
            //    table: "auth_user_user_permissions",
            //    column: "permission_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__authtoke__B9BE370E43536C96",
            //    table: "authtoken_token",
            //    column: "user_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "base_adminlog_content_type_id_3e553c30",
            //    table: "base_adminlog",
            //    column: "content_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "base_adminlog_user_id_ecf659f8",
            //    table: "base_adminlog",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__base_att__14AA806DCDC722DD",
            //    table: "base_attparamdepts",
            //    column: "rulename",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__base_aut__4ED2915622BE2F44",
            //    table: "base_autoattexporttask",
            //    column: "task_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__base_aut__4ED29156F6954F68",
            //    table: "base_autoexporttask",
            //    column: "task_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "base_autoimporttask_company_id_d18431a1",
            //    table: "base_autoimporttask",
            //    column: "company_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__base_aut__4ED29156049EE0E7",
            //    table: "base_autoimporttask",
            //    column: "task_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "base_bookmark_content_type_id_b6a0e799",
            //    table: "base_bookmark",
            //    column: "content_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "base_bookmark_user_id_5f2d5ca2",
            //    table: "base_bookmark",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__base_fix__4ED291564D428DAB",
            //    table: "base_fixedexporttask",
            //    column: "task_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "base_linenotifysetting_line_notify_dept_id_0643a5ed",
            //    table: "base_linenotifysetting",
            //    column: "line_notify_dept_id");

            //migrationBuilder.CreateIndex(
            //    name: "base_linenotifysetting_line_notify_dept_id_line_notify_token_message_type_dd79374f_uniq",
            //    table: "base_linenotifysetting",
            //    columns: new[] { "line_notify_dept_id", "line_notify_token", "message_type" },
            //    unique: true,
            //    filter: "[line_notify_dept_id] IS NOT NULL AND [line_notify_token] IS NOT NULL AND [message_type] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "base_sysparam_para_name_para_type_3086789a_uniq",
            //    table: "base_sysparam",
            //    columns: new[] { "para_name", "para_type" },
            //    unique: true,
            //    filter: "[para_type] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__base_sys__B9ADD0FA70017C93",
            //    table: "base_sysparamdept",
            //    column: "rule_name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "django_admin_log_content_type_id_c4bce8eb",
            //    table: "django_admin_log",
            //    column: "content_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "django_admin_log_user_id_c564eba6",
            //    table: "django_admin_log",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "django_celery_beat_periodictask_clocked_id_47a69f82",
            //    table: "django_celery_beat_periodictask",
            //    column: "clocked_id");

            //migrationBuilder.CreateIndex(
            //    name: "django_celery_beat_periodictask_crontab_id_d3cba168",
            //    table: "django_celery_beat_periodictask",
            //    column: "crontab_id");

            //migrationBuilder.CreateIndex(
            //    name: "django_celery_beat_periodictask_interval_id_a8ca27da",
            //    table: "django_celery_beat_periodictask",
            //    column: "interval_id");

            //migrationBuilder.CreateIndex(
            //    name: "django_celery_beat_periodictask_solar_id_a87ce72c",
            //    table: "django_celery_beat_periodictask",
            //    column: "solar_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__django_c__72E12F1BBE3D828F",
            //    table: "django_celery_beat_periodictask",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "django_celery_beat_solarschedule_event_latitude_longitude_ba64999a_uniq",
            //    table: "django_celery_beat_solarschedule",
            //    columns: new[] { "event", "latitude", "longitude" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "django_content_type_app_label_model_76bd3d3b_uniq",
            //    table: "django_content_type",
            //    columns: new[] { "app_label", "model" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "django_session_expire_date_a5c62663",
            //    table: "django_session",
            //    column: "expire_date");

            //migrationBuilder.CreateIndex(
            //    name: "ep_eptransaction_emp_code_check_datetime_0b54f31f_uniq",
            //    table: "ep_eptransaction",
            //    columns: new[] { "emp_code", "check_datetime" },
            //    unique: true,
            //    filter: "[check_datetime] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "ep_eptransaction_emp_id_1006883f",
            //    table: "ep_eptransaction",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "ep_eptransaction_terminal_id_4490b209",
            //    table: "ep_eptransaction",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "guardian_groupobjectpermission_content_type_id_7ade36b8",
            //    table: "guardian_groupobjectpermission",
            //    column: "content_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "guardian_groupobjectpermission_group_id_4bbbfb62",
            //    table: "guardian_groupobjectpermission",
            //    column: "group_id");

            //migrationBuilder.CreateIndex(
            //    name: "guardian_groupobjectpermission_group_id_permission_id_object_pk_3f189f7c_uniq",
            //    table: "guardian_groupobjectpermission",
            //    columns: new[] { "group_id", "permission_id", "object_pk" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "guardian_groupobjectpermission_permission_id_36572738",
            //    table: "guardian_groupobjectpermission",
            //    column: "permission_id");

            //migrationBuilder.CreateIndex(
            //    name: "guardian_userobjectpermission_content_type_id_2e892405",
            //    table: "guardian_userobjectpermission",
            //    column: "content_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "guardian_userobjectpermission_permission_id_71807bfc",
            //    table: "guardian_userobjectpermission",
            //    column: "permission_id");

            //migrationBuilder.CreateIndex(
            //    name: "guardian_userobjectpermission_user_id_d5c1e964",
            //    table: "guardian_userobjectpermission",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "guardian_userobjectpermission_user_id_permission_id_object_pk_b0b3d2fc_uniq",
            //    table: "guardian_userobjectpermission",
            //    columns: new[] { "user_id", "permission_id", "object_pk" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "iclock_biodata_employee_id_bio_no_bio_index_bio_type_bio_format_major_ver_minor_ver_bc5286ed_uniq",
            //    table: "iclock_biodata",
            //    columns: new[] { "employee_id", "bio_no", "bio_index", "bio_type", "bio_format", "major_ver", "minor_ver" },
            //    unique: true,
            //    filter: "[bio_no] IS NOT NULL AND [bio_index] IS NOT NULL AND [bio_format] IS NOT NULL AND [minor_ver] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_biodata_employee_id_ff748ea7",
            //    table: "iclock_biodata",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_biophoto_employee_id_3dba5819",
            //    table: "iclock_biophoto",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_errorcommandlog_terminal_id_3b2d7cbd",
            //    table: "iclock_errorcommandlog",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_privatemessage_employee_id_e84a34c0",
            //    table: "iclock_privatemessage",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_privatemessage_message_id_e3145d3b",
            //    table: "iclock_privatemessage",
            //    column: "message_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_publicmessage_message_id_7d125e28",
            //    table: "iclock_publicmessage",
            //    column: "message_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_publicmessage_terminal_id_c3b5e4cf",
            //    table: "iclock_publicmessage",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminal_area_id_c019c6f0",
            //    table: "iclock_terminal",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__iclock_t__3214186DD5D1AD8B",
            //    table: "iclock_terminal",
            //    column: "sn",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminalcommand_terminal_id_3dcf836f",
            //    table: "iclock_terminalcommand",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminalcommandlog_terminal_id_35ea8b2b",
            //    table: "iclock_terminalcommandlog",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminallog_terminal_id_667b3ea7",
            //    table: "iclock_terminallog",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminalparameter_terminal_id_443872e3",
            //    table: "iclock_terminalparameter",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminalparameter_terminal_id_param_name_8abbb5c0_uniq",
            //    table: "iclock_terminalparameter",
            //    columns: new[] { "terminal_id", "param_name" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminaluploadlog_terminal_id_9c9a7664",
            //    table: "iclock_terminaluploadlog",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_terminalworkcode_company_id_77625f26",
            //    table: "iclock_terminalworkcode",
            //    column: "company_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__iclock_t__357D4CF9ED153EBD",
            //    table: "iclock_terminalworkcode",
            //    column: "code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "iclock_transaction_company_code_emp_code_punch_time_2665c3d7_uniq",
            //    table: "iclock_transaction",
            //    columns: new[] { "company_code", "emp_code", "punch_time" },
            //    unique: true,
            //    filter: "[company_code] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_transaction_emp_id_60fa3521",
            //    table: "iclock_transaction",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_transaction_terminal_id_451c81c2",
            //    table: "iclock_transaction",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "iclock_transactionproofcmd_terminal_id_08b81e1e",
            //    table: "iclock_transactionproofcmd",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingentity_room_id_bc2c738e",
            //    table: "meeting_meetingentity",
            //    column: "room_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__meeting___357D4CF95D163607",
            //    table: "meeting_meetingentity",
            //    column: "code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingentity_attender_employee_id_ee898064",
            //    table: "meeting_meetingentity_attender",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingentity_attender_meetingentity_id_b96dbc7d",
            //    table: "meeting_meetingentity_attender",
            //    column: "meetingentity_id");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingentity_attender_meetingentity_id_employee_id_b556fc2d_uniq",
            //    table: "meeting_meetingentity_attender",
            //    columns: new[] { "meetingentity_id", "employee_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingmanuallog_meeting_id_a672eaaf",
            //    table: "meeting_meetingmanuallog",
            //    column: "meeting_id");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingpayloadbase_emp_id_ed6ec148",
            //    table: "meeting_meetingpayloadbase",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingpayloadbase_meeting_id_ca9d20cc",
            //    table: "meeting_meetingpayloadbase",
            //    column: "meeting_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__meeting___357D4CF9C8617BF7",
            //    table: "meeting_meetingroom",
            //    column: "code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingroomdevice_room_id_e000d78d",
            //    table: "meeting_meetingroomdevice",
            //    column: "room_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__meeting___3B085D8A87D2DAE9",
            //    table: "meeting_meetingroomdevice",
            //    column: "device_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingtransaction_emp_id_fbcdd686",
            //    table: "meeting_meetingtransaction",
            //    column: "emp_id");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingtransaction_emp_id_punch_datetime_65665dce_uniq",
            //    table: "meeting_meetingtransaction",
            //    columns: new[] { "emp_id", "punch_datetime" },
            //    unique: true,
            //    filter: "[emp_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingtransaction_meeting_id_e4e505e5",
            //    table: "meeting_meetingtransaction",
            //    column: "meeting_id");

            //migrationBuilder.CreateIndex(
            //    name: "meeting_meetingtransaction_terminal_id_047426f2",
            //    table: "meeting_meetingtransaction",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_announcement_admin_id_6af3868c",
            //    table: "mobile_announcement",
            //    column: "admin_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_announcement_init_sender_id_2f5e35bd",
            //    table: "mobile_announcement",
            //    column: "init_sender_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_announcement_receiver_id_ddf2a860",
            //    table: "mobile_announcement",
            //    column: "receiver_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_appnotification_admin_id_29c27197",
            //    table: "mobile_appnotification",
            //    column: "admin_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_appnotification_init_sender_id_d8aff845",
            //    table: "mobile_appnotification",
            //    column: "init_sender_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_appnotification_receiver_id_90c4a355",
            //    table: "mobile_appnotification",
            //    column: "receiver_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsfordepartment_department_id_988ccf22",
            //    table: "mobile_gpsfordepartment",
            //    column: "department_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsfordepartment_location_gpsfordepartment_id_23e9af3a",
            //    table: "mobile_gpsfordepartment_location",
            //    column: "gpsfordepartment_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsfordepartment_location_gpsfordepartment_id_gpslocation_id_58226033_uniq",
            //    table: "mobile_gpsfordepartment_location",
            //    columns: new[] { "gpsfordepartment_id", "gpslocation_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsfordepartment_location_gpslocation_id_48b82e9e",
            //    table: "mobile_gpsfordepartment_location",
            //    column: "gpslocation_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsforemployee_employee_id_982b7cef",
            //    table: "mobile_gpsforemployee",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsforemployee_location_gpsforemployee_id_a52023d5",
            //    table: "mobile_gpsforemployee_location",
            //    column: "gpsforemployee_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsforemployee_location_gpsforemployee_id_gpslocation_id_9ceb93bf_uniq",
            //    table: "mobile_gpsforemployee_location",
            //    columns: new[] { "gpsforemployee_id", "gpslocation_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "mobile_gpsforemployee_location_gpslocation_id_497a214f",
            //    table: "mobile_gpsforemployee_location",
            //    column: "gpslocation_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_mobileapirequestlog_path_830043b5",
            //    table: "mobile_mobileapirequestlog",
            //    column: "path");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_mobileapirequestlog_requested_at_a8c85067",
            //    table: "mobile_mobileapirequestlog",
            //    column: "requested_at");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_mobileapirequestlog_status_code_c2de0c48",
            //    table: "mobile_mobileapirequestlog",
            //    column: "status_code");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_mobileapirequestlog_user_id_dfd3ded1",
            //    table: "mobile_mobileapirequestlog",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_mobileapirequestlog_view_50dbf600",
            //    table: "mobile_mobileapirequestlog",
            //    column: "view");

            //migrationBuilder.CreateIndex(
            //    name: "mobile_mobileapirequestlog_view_method_2e13cf95",
            //    table: "mobile_mobileapirequestlog",
            //    column: "view_method");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__payroll___72E12F1BE7F6A360",
            //    table: "payroll_deductionformula",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_emploan_employee_id_97a251ef",
            //    table: "payroll_emploan",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__payroll___C52E0BA9D450BF72",
            //    table: "payroll_emppayrollprofile",
            //    column: "employee_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_exceptionformula_pay_code_id_97609b51",
            //    table: "payroll_exceptionformula",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__payroll___72E12F1BB70CBDFB",
            //    table: "payroll_exceptionformula",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_extradeduction_employee_id_53072441",
            //    table: "payroll_extradeduction",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_extraincrease_employee_id_f902e6bb",
            //    table: "payroll_extraincrease",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__payroll___72E12F1BBBA07EEB",
            //    table: "payroll_increasementformula",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_leaveformula_pay_code_id_63c7b4bd",
            //    table: "payroll_leaveformula",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__payroll___72E12F1B3FE7E822",
            //    table: "payroll_leaveformula",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_overtimeformula_pay_code_id_36d2f10e",
            //    table: "payroll_overtimeformula",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__payroll___72E12F1BE770EFB4",
            //    table: "payroll_overtimeformula",
            //    column: "name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_payrollpayload_employee_id_bc868f2b",
            //    table: "payroll_payrollpayload",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_payrollpayloadpaycode_pay_code_id_c057af1f",
            //    table: "payroll_payrollpayloadpaycode",
            //    column: "pay_code_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_payrollpayloadpaycode_payload_id_f085c4e8",
            //    table: "payroll_payrollpayloadpaycode",
            //    column: "payload_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_reimbursement_employee_id_c4bbde36",
            //    table: "payroll_reimbursement",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salaryadvance_employee_id_2abd43e5",
            //    table: "payroll_salaryadvance",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_employee_id_98996e15",
            //    table: "payroll_salarystructure",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_deductionformula_deductionformula_id_b174d5b6",
            //    table: "payroll_salarystructure_deductionformula",
            //    column: "deductionformula_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_deductionformula_salarystructure_id_5ca7cdb5",
            //    table: "payroll_salarystructure_deductionformula",
            //    column: "salarystructure_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_deductionformula_salarystructure_id_deductionformula_id_794e8449_uniq",
            //    table: "payroll_salarystructure_deductionformula",
            //    columns: new[] { "salarystructure_id", "deductionformula_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_exceptionformula_exceptionformula_id_8f6dadb3",
            //    table: "payroll_salarystructure_exceptionformula",
            //    column: "exceptionformula_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_exceptionformula_salarystructure_id_3c087208",
            //    table: "payroll_salarystructure_exceptionformula",
            //    column: "salarystructure_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_exceptionformula_salarystructure_id_exceptionformula_id_a5e869ff_uniq",
            //    table: "payroll_salarystructure_exceptionformula",
            //    columns: new[] { "salarystructure_id", "exceptionformula_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_increasementformula_increasementformula_id_3cd77082",
            //    table: "payroll_salarystructure_increasementformula",
            //    column: "increasementformula_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_increasementformula_salarystructure_id_8752401c",
            //    table: "payroll_salarystructure_increasementformula",
            //    column: "salarystructure_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_increasementformula_salarystructure_id_increasementformula_id_749132b3_uniq",
            //    table: "payroll_salarystructure_increasementformula",
            //    columns: new[] { "salarystructure_id", "increasementformula_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_leaveformula_leaveformula_id_049f9024",
            //    table: "payroll_salarystructure_leaveformula",
            //    column: "leaveformula_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_leaveformula_salarystructure_id_cf98fdd7",
            //    table: "payroll_salarystructure_leaveformula",
            //    column: "salarystructure_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_leaveformula_salarystructure_id_leaveformula_id_4efdce30_uniq",
            //    table: "payroll_salarystructure_leaveformula",
            //    columns: new[] { "salarystructure_id", "leaveformula_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_overtimeformula_overtimeformula_id_40ad89ef",
            //    table: "payroll_salarystructure_overtimeformula",
            //    column: "overtimeformula_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_overtimeformula_salarystructure_id_64f75042",
            //    table: "payroll_salarystructure_overtimeformula",
            //    column: "salarystructure_id");

            //migrationBuilder.CreateIndex(
            //    name: "payroll_salarystructure_overtimeformula_salarystructure_id_overtimeformula_id_0d0a0e81_uniq",
            //    table: "payroll_salarystructure_overtimeformula",
            //    columns: new[] { "salarystructure_id", "overtimeformula_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "personnel_area_company_id_59750eb5",
            //    table: "personnel_area",
            //    column: "company_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_area_company_id_area_code_aa39c55c_uniq",
            //    table: "personnel_area",
            //    columns: new[] { "company_id", "area_code" },
            //    unique: true,
            //    filter: "[company_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_area_parent_area_id_39028fda",
            //    table: "personnel_area",
            //    column: "parent_area_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_assignareaemployee_area_id_6f049d6a",
            //    table: "personnel_assignareaemployee",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_assignareaemployee_employee_id_a3d4dd25",
            //    table: "personnel_assignareaemployee",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__1B8BDCA7331EFC4D",
            //    table: "personnel_certification",
            //    column: "cert_name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__34D3AE57273AF928",
            //    table: "personnel_certification",
            //    column: "cert_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__F4E508EA4B6A5395",
            //    table: "personnel_company",
            //    column: "company_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "personnel_department_company_id_00867fd8",
            //    table: "personnel_department",
            //    column: "company_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_department_company_id_dept_code_dfa8fff7_uniq",
            //    table: "personnel_department",
            //    columns: new[] { "company_id", "dept_code" },
            //    unique: true,
            //    filter: "[company_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_department_dept_manager_id_c5124a7d",
            //    table: "personnel_department",
            //    column: "dept_manager_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_department_parent_dept_id_d0b44024",
            //    table: "personnel_department",
            //    column: "parent_dept_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_company_id_95b3fd72",
            //    table: "personnel_employee",
            //    column: "company_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_company_id_emp_code_81daa575_uniq",
            //    table: "personnel_employee",
            //    columns: new[] { "company_id", "emp_code" },
            //    unique: true,
            //    filter: "[company_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_department_id_068bbd08",
            //    table: "personnel_employee",
            //    column: "department_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_position_id_c9321343",
            //    table: "personnel_employee",
            //    column: "position_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_superior_id_ad6e1c47",
            //    table: "personnel_employee",
            //    column: "superior_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_area_area_id_64c21925",
            //    table: "personnel_employee_area",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_area_employee_id_8e5cec21",
            //    table: "personnel_employee_area",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_area_employee_id_area_id_00b3d777_uniq",
            //    table: "personnel_employee_area",
            //    columns: new[] { "employee_id", "area_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_flow_role_employee_id_c27f8a56",
            //    table: "personnel_employee_flow_role",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_flow_role_employee_id_workflowrole_id_46b0e5e0_uniq",
            //    table: "personnel_employee_flow_role",
            //    columns: new[] { "employee_id", "workflowrole_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employee_flow_role_workflowrole_id_4704db32",
            //    table: "personnel_employee_flow_role",
            //    column: "workflowrole_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employeecalendar_employee_id_165e0779",
            //    table: "personnel_employeecalendar",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employeecalendar_employee_id_calendar_10f7278d_uniq",
            //    table: "personnel_employeecalendar",
            //    columns: new[] { "employee_id", "calendar" },
            //    unique: true,
            //    filter: "[calendar] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employeecertification_certification_id_faabed40",
            //    table: "personnel_employeecertification",
            //    column: "certification_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employeecertification_employee_id_b7bd3867",
            //    table: "personnel_employeecertification",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_employeecertification_employee_id_certification_id_7bcf4c7d_uniq",
            //    table: "personnel_employeecertification",
            //    columns: new[] { "employee_id", "certification_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__A0FDB96964CC3AFD",
            //    table: "personnel_employeecustomattribute",
            //    column: "attr_name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__C52E0BA993C472B2",
            //    table: "personnel_employeeextrainfo",
            //    column: "employee_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__1299A8604BD95367",
            //    table: "personnel_employeeprofile",
            //    column: "emp_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__C52E0BA98E0BFD53",
            //    table: "personnel_employment",
            //    column: "employee_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "personnel_position_company_id_f06c5d2a",
            //    table: "personnel_position",
            //    column: "company_id");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_position_company_id_position_code_4708726e_uniq",
            //    table: "personnel_position",
            //    columns: new[] { "company_id", "position_code" },
            //    unique: true,
            //    filter: "[company_id] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "personnel_position_parent_position_id_a496a36b",
            //    table: "personnel_position",
            //    column: "parent_position_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__personne__C52E0BA9DBB933AC",
            //    table: "personnel_resign",
            //    column: "employee_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "rest_framework_tracking_apirequestlog_path_fe81f91b",
            //    table: "rest_framework_tracking_apirequestlog",
            //    column: "path");

            //migrationBuilder.CreateIndex(
            //    name: "rest_framework_tracking_apirequestlog_requested_at_b6f1c2f2",
            //    table: "rest_framework_tracking_apirequestlog",
            //    column: "requested_at");

            //migrationBuilder.CreateIndex(
            //    name: "rest_framework_tracking_apirequestlog_status_code_3c9e2003",
            //    table: "rest_framework_tracking_apirequestlog",
            //    column: "status_code");

            //migrationBuilder.CreateIndex(
            //    name: "rest_framework_tracking_apirequestlog_user_id_671b70b7",
            //    table: "rest_framework_tracking_apirequestlog",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "rest_framework_tracking_apirequestlog_view_5bd1e407",
            //    table: "rest_framework_tracking_apirequestlog",
            //    column: "view");

            //migrationBuilder.CreateIndex(
            //    name: "rest_framework_tracking_apirequestlog_view_method_dd790881_idx",
            //    table: "rest_framework_tracking_apirequestlog",
            //    column: "view_method");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__staff_st__B9BE370E63CCB545",
            //    table: "staff_stafftoken",
            //    column: "user_id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "sync_area_area_code_area_name_200046d1_uniq",
            //    table: "sync_area",
            //    columns: new[] { "area_code", "area_name" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "sync_department_dept_code_dept_name_93923213_uniq",
            //    table: "sync_department",
            //    columns: new[] { "dept_code", "dept_name" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "sync_employee_emp_code_521bf06d_uniq",
            //    table: "sync_employee",
            //    column: "emp_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "sync_job_job_code_job_name_4ec5619e_uniq",
            //    table: "sync_job",
            //    columns: new[] { "job_code", "job_name" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "visitor_reservation_cert_type_id_4f047f2a",
            //    table: "visitor_reservation",
            //    column: "cert_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_reservation_visit_department_id_2d293e10",
            //    table: "visitor_reservation",
            //    column: "visit_department_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_reservation_visit_reason_id_c9ac83ac",
            //    table: "visitor_reservation",
            //    column: "visit_reason_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__visitor___8C752E087E9DCAFA",
            //    table: "visitor_visitor",
            //    column: "visitor_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_cert_type_id_f62ea604",
            //    table: "visitor_visitor",
            //    column: "cert_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_visit_department_id_f7dbdcb4",
            //    table: "visitor_visitor",
            //    column: "visit_department_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_visit_reason_id_4b9a2d23",
            //    table: "visitor_visitor",
            //    column: "visit_reason_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_visited_id_8043a7ea",
            //    table: "visitor_visitor",
            //    column: "visited_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_acc_groups_accgroups_id_b1487149",
            //    table: "visitor_visitor_acc_groups",
            //    column: "accgroups_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_acc_groups_visitor_id_8ce09562",
            //    table: "visitor_visitor_acc_groups",
            //    column: "visitor_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_acc_groups_visitor_id_accgroups_id_bb522609_uniq",
            //    table: "visitor_visitor_acc_groups",
            //    columns: new[] { "visitor_id", "accgroups_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_area_area_id_b402c047",
            //    table: "visitor_visitor_area",
            //    column: "area_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_area_visitor_id_98d7ed05",
            //    table: "visitor_visitor_area",
            //    column: "visitor_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitor_area_visitor_id_area_id_27d158cc_uniq",
            //    table: "visitor_visitor_area",
            //    columns: new[] { "visitor_id", "area_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitorbiodata_visitor_id_b944ed37",
            //    table: "visitor_visitorbiodata",
            //    column: "visitor_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitorbiodata_visitor_id_bio_no_bio_index_bio_type_bio_format_major_ver_e5d598fb_uniq",
            //    table: "visitor_visitorbiodata",
            //    columns: new[] { "visitor_id", "bio_no", "bio_index", "bio_type", "bio_format", "major_ver" },
            //    unique: true,
            //    filter: "[bio_no] IS NOT NULL AND [bio_index] IS NOT NULL AND [bio_format] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitorbiophoto_visitor_id_9816daf7",
            //    table: "visitor_visitorbiophoto",
            //    column: "visitor_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitorlog_visitor_id_ebaafde1",
            //    table: "visitor_visitorlog",
            //    column: "visitor_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitortransaction_terminal_id_7527ef69",
            //    table: "visitor_visitortransaction",
            //    column: "terminal_id");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitortransaction_visitor_code_punch_time_2b871513_uniq",
            //    table: "visitor_visitortransaction",
            //    columns: new[] { "visitor_code", "punch_time" },
            //    unique: true,
            //    filter: "[punch_time] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "visitor_visitortransaction_visitor_id_0ee95624",
            //    table: "visitor_visitortransaction",
            //    column: "visitor_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_nodeinstance_approver_employee_id_d36cd45d",
            //    table: "workflow_nodeinstance",
            //    column: "approver_employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_nodeinstance_workflow_instance_id_afe84fe4",
            //    table: "workflow_nodeinstance",
            //    column: "workflow_instance_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_nodeinstance_workflow_node_id_166f36c4",
            //    table: "workflow_nodeinstance",
            //    column: "workflow_node_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__workflow__12BE0D46CDFE28EE",
            //    table: "workflow_workflowengine",
            //    column: "workflow_code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowengine_applicant_position_id_8a65e03a",
            //    table: "workflow_workflowengine",
            //    column: "applicant_position_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowengine_content_type_id_f7345c20",
            //    table: "workflow_workflowengine",
            //    column: "content_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowengine_departments_id_0f06d4c7",
            //    table: "workflow_workflowengine",
            //    column: "departments_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowengine_employee_employee_id_803a409e",
            //    table: "workflow_workflowengine_employee",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowengine_employee_workflowengine_id_6ebcc5f2",
            //    table: "workflow_workflowengine_employee",
            //    column: "workflowengine_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowengine_employee_workflowengine_id_employee_id_8128deb2_uniq",
            //    table: "workflow_workflowengine_employee",
            //    columns: new[] { "workflowengine_id", "employee_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowinstance_employee_id_c7cff08e",
            //    table: "workflow_workflowinstance",
            //    column: "employee_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflowinstance_workflow_engine_id_1e6ac40f",
            //    table: "workflow_workflowinstance",
            //    column: "workflow_engine_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflownode_workflow_engine_id_04c8f470",
            //    table: "workflow_workflownode",
            //    column: "workflow_engine_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflownode_approver_workflownode_id_d814c941",
            //    table: "workflow_workflownode_approver",
            //    column: "workflownode_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflownode_approver_workflownode_id_workflowrole_id_7543ba37_uniq",
            //    table: "workflow_workflownode_approver",
            //    columns: new[] { "workflownode_id", "workflowrole_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflownode_approver_workflowrole_id_c8e00d42",
            //    table: "workflow_workflownode_approver",
            //    column: "workflowrole_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflownode_notifier_workflownode_id_57298016",
            //    table: "workflow_workflownode_notifier",
            //    column: "workflownode_id");

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflownode_notifier_workflownode_id_workflowrole_id_cac02b37_uniq",
            //    table: "workflow_workflownode_notifier",
            //    columns: new[] { "workflownode_id", "workflowrole_id" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "workflow_workflownode_notifier_workflowrole_id_73de7fc2",
            //    table: "workflow_workflownode_notifier",
            //    column: "workflowrole_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__workflow__783254B1F570EE36",
            //    table: "workflow_workflowrole",
            //    column: "role_name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__workflow__BAE6307595F3A907",
            //    table: "workflow_workflowrole",
            //    column: "role_code",
            //    unique: true);

            //migrationBuilder.AddForeignKey(
            //    name: "acc_accholiday_holiday_id_a9efe924_fk_att_holiday_id",
            //    table: "acc_accholiday",
            //    column: "holiday_id",
            //    principalTable: "att_holiday",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "acc_accprivilege_employee_id_5fc55f95_fk_personnel_employee_id",
            //    table: "acc_accprivilege",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_attemployee_emp_id_52457e3c_fk_personnel_employee_id",
            //    table: "att_attemployee",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_attschedule_employee_id_caa61686_fk_personnel_employee_id",
            //    table: "att_attschedule",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_changeschedule_workflowinstance_ptr_id_cee602bb_fk_workflow_workflowinstance_id",
            //    table: "att_changeschedule",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_departmentpolicy_department_id_77059a9d_fk_personnel_department_id",
            //    table: "att_departmentpolicy",
            //    column: "department_id",
            //    principalTable: "personnel_department",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_departmentschedule_department_id_c68fca3d_fk_personnel_department_id",
            //    table: "att_departmentschedule",
            //    column: "department_id",
            //    principalTable: "personnel_department",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_deptattrule_department_id_f333c8f0_fk_personnel_department_id",
            //    table: "att_deptattrule",
            //    column: "department_id",
            //    principalTable: "personnel_department",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_holiday_department_id_fbbbd185_fk_personnel_department_id",
            //    table: "att_holiday",
            //    column: "department_id",
            //    principalTable: "personnel_department",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_leave_workflowinstance_ptr_id_39aaa9d9_fk_workflow_workflowinstance_id",
            //    table: "att_leave",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_leaveyearbalance_employee_id_14febdb3_fk_personnel_employee_id",
            //    table: "att_leaveyearbalance",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_manuallog_workflowinstance_ptr_id_22a3fbd0_fk_workflow_workflowinstance_id",
            //    table: "att_manuallog",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_overtime_workflowinstance_ptr_id_6bd6a6f4_fk_workflow_workflowinstance_id",
            //    table: "att_overtime",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadattcode_emp_id_36569f54_fk_personnel_employee_id",
            //    table: "att_payloadattcode",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadbase_emp_id_2c0f6a7b_fk_personnel_employee_id",
            //    table: "att_payloadbase",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadeffectpunch_emp_id_67e28e01_fk_personnel_employee_id",
            //    table: "att_payloadeffectpunch",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadeffectpunch_trans_id_94affbe6_fk_iclock_transaction_id",
            //    table: "att_payloadeffectpunch",
            //    column: "trans_id",
            //    principalTable: "iclock_transaction",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadmulpunchset_emp_id_f47610c8_fk_personnel_employee_id",
            //    table: "att_payloadmulpunchset",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadparing_emp_id_c5daac4f_fk_personnel_employee_id",
            //    table: "att_payloadparing",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadparing_in_trans_id_50a8040e_fk_iclock_transaction_id",
            //    table: "att_payloadparing",
            //    column: "in_trans_id",
            //    principalTable: "iclock_transaction",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadparing_out_trans_id_8b2375b9_fk_iclock_transaction_id",
            //    table: "att_payloadparing",
            //    column: "out_trans_id",
            //    principalTable: "iclock_transaction",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadpaycode_emp_id_78e75279_fk_personnel_employee_id",
            //    table: "att_payloadpaycode",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadpunch_emp_id_053da2f0_fk_personnel_employee_id",
            //    table: "att_payloadpunch",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadpunch_orig_id_16b26416_fk_iclock_transaction_id",
            //    table: "att_payloadpunch",
            //    column: "orig_id",
            //    principalTable: "iclock_transaction",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadtimecard_emp_id_47caeab4_fk_personnel_employee_id",
            //    table: "att_payloadtimecard",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadtimecard_in_trans_id_d0e9c411_fk_iclock_transaction_id",
            //    table: "att_payloadtimecard",
            //    column: "in_trans_id",
            //    principalTable: "iclock_transaction",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_payloadtimecard_out_trans_id_aff7023d_fk_iclock_transaction_id",
            //    table: "att_payloadtimecard",
            //    column: "out_trans_id",
            //    principalTable: "iclock_transaction",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_reporttemplate_employee_id_4f80d866_fk_personnel_employee_id",
            //    table: "att_reporttemplate",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_temporaryschedule_employee_id_2b2b94c2_fk_personnel_employee_id",
            //    table: "att_temporaryschedule",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_tempschedule_employee_id_b89c7e54_fk_personnel_employee_id",
            //    table: "att_tempschedule",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_training_workflowinstance_ptr_id_0aef1508_fk_workflow_workflowinstance_id",
            //    table: "att_training",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "att_webpunch_workflowinstance_ptr_id_c5f1c02e_fk_workflow_workflowinstance_id",
            //    table: "att_webpunch",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "auth_user_auth_dept_department_id_5866c514_fk_personnel_department_id",
            //    table: "auth_user_auth_dept",
            //    column: "department_id",
            //    principalTable: "personnel_department",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "base_linenotifysetting_line_notify_dept_id_0643a5ed_fk_personnel_department_id",
            //    table: "base_linenotifysetting",
            //    column: "line_notify_dept_id",
            //    principalTable: "personnel_department",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "ep_eptransaction_emp_id_1006883f_fk_personnel_employee_id",
            //    table: "ep_eptransaction",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "iclock_biodata_employee_id_ff748ea7_fk_personnel_employee_id",
            //    table: "iclock_biodata",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "iclock_biophoto_employee_id_3dba5819_fk_personnel_employee_id",
            //    table: "iclock_biophoto",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "iclock_privatemessage_employee_id_e84a34c0_fk_personnel_employee_id",
            //    table: "iclock_privatemessage",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "iclock_transaction_emp_id_60fa3521_fk_personnel_employee_id",
            //    table: "iclock_transaction",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "meeting_meetingentity_workflowinstance_ptr_id_dbd9ab40_fk_workflow_workflowinstance_id",
            //    table: "meeting_meetingentity",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "meeting_meetingentity_attender_employee_id_ee898064_fk_personnel_employee_id",
            //    table: "meeting_meetingentity_attender",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "meeting_meetingmanuallog_workflowinstance_ptr_id_bd514862_fk_workflow_workflowinstance_id",
            //    table: "meeting_meetingmanuallog",
            //    column: "workflowinstance_ptr_id",
            //    principalTable: "workflow_workflowinstance",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "meeting_meetingpayloadbase_emp_id_ed6ec148_fk_personnel_employee_id",
            //    table: "meeting_meetingpayloadbase",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "meeting_meetingtransaction_emp_id_fbcdd686_fk_personnel_employee_id",
            //    table: "meeting_meetingtransaction",
            //    column: "emp_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "mobile_announcement_init_sender_id_2f5e35bd_fk_personnel_employee_id",
            //    table: "mobile_announcement",
            //    column: "init_sender_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "mobile_announcement_receiver_id_ddf2a860_fk_personnel_employee_id",
            //    table: "mobile_announcement",
            //    column: "receiver_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "mobile_appnotification_init_sender_id_d8aff845_fk_personnel_employee_id",
            //    table: "mobile_appnotification",
            //    column: "init_sender_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "mobile_appnotification_receiver_id_90c4a355_fk_personnel_employee_id",
            //    table: "mobile_appnotification",
            //    column: "receiver_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "mobile_gpsfordepartment_department_id_988ccf22_fk_personnel_department_id",
            //    table: "mobile_gpsfordepartment",
            //    column: "department_id",
            //    principalTable: "personnel_department",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "mobile_gpsforemployee_employee_id_982b7cef_fk_personnel_employee_id",
            //    table: "mobile_gpsforemployee",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "mobile_mobileapirequestlog_user_id_dfd3ded1_fk_personnel_employee_id",
            //    table: "mobile_mobileapirequestlog",
            //    column: "user_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_emploan_employee_id_97a251ef_fk_personnel_employee_id",
            //    table: "payroll_emploan",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_emppayrollprofile_employee_id_6c97078c_fk_personnel_employee_id",
            //    table: "payroll_emppayrollprofile",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_extradeduction_employee_id_53072441_fk_personnel_employee_id",
            //    table: "payroll_extradeduction",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_extraincrease_employee_id_f902e6bb_fk_personnel_employee_id",
            //    table: "payroll_extraincrease",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_payrollpayload_employee_id_bc868f2b_fk_personnel_employee_id",
            //    table: "payroll_payrollpayload",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_reimbursement_employee_id_c4bbde36_fk_personnel_employee_id",
            //    table: "payroll_reimbursement",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_salaryadvance_employee_id_2abd43e5_fk_personnel_employee_id",
            //    table: "payroll_salaryadvance",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "payroll_salarystructure_employee_id_98996e15_fk_personnel_employee_id",
            //    table: "payroll_salarystructure",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "personnel_assignareaemployee_employee_id_a3d4dd25_fk_personnel_employee_id",
            //    table: "personnel_assignareaemployee",
            //    column: "employee_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");

            //migrationBuilder.AddForeignKey(
            //    name: "personnel_department_dept_manager_id_c5124a7d_fk_personnel_employee_id",
            //    table: "personnel_department",
            //    column: "dept_manager_id",
            //    principalTable: "personnel_employee",
            //    principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "personnel_department_dept_manager_id_c5124a7d_fk_personnel_employee_id",
                table: "personnel_department");

            migrationBuilder.DropTable(
                name: "_zz");

            migrationBuilder.DropTable(
                name: "acc_acccombination");

            migrationBuilder.DropTable(
                name: "acc_accholiday");

            migrationBuilder.DropTable(
                name: "acc_accprivilege");

            migrationBuilder.DropTable(
                name: "acc_accterminal");

            migrationBuilder.DropTable(
                name: "accounts_adminbiodata");

            migrationBuilder.DropTable(
                name: "accounts_usernotification");

            migrationBuilder.DropTable(
                name: "att_attcalclog");

            migrationBuilder.DropTable(
                name: "att_attemployee");

            migrationBuilder.DropTable(
                name: "att_attpolicy");

            migrationBuilder.DropTable(
                name: "att_attreportsetting");

            migrationBuilder.DropTable(
                name: "att_attrule");

            migrationBuilder.DropTable(
                name: "att_attschedule");

            migrationBuilder.DropTable(
                name: "att_calculatelastdate");

            migrationBuilder.DropTable(
                name: "att_calculatetask");

            migrationBuilder.DropTable(
                name: "att_changeschedule");

            migrationBuilder.DropTable(
                name: "att_departmentpolicy");

            migrationBuilder.DropTable(
                name: "att_departmentschedule");

            migrationBuilder.DropTable(
                name: "att_deptattrule");

            migrationBuilder.DropTable(
                name: "att_grouppolicy");

            migrationBuilder.DropTable(
                name: "att_groupschedule");

            migrationBuilder.DropTable(
                name: "att_leavegroupdetail");

            migrationBuilder.DropTable(
                name: "att_leaveyearbalance");

            migrationBuilder.DropTable(
                name: "att_manuallog");

            migrationBuilder.DropTable(
                name: "att_overtime");

            migrationBuilder.DropTable(
                name: "att_overtimepolicy");

            migrationBuilder.DropTable(
                name: "att_payloadattcode");

            migrationBuilder.DropTable(
                name: "att_payloadbase");

            migrationBuilder.DropTable(
                name: "att_payloadbreak");

            migrationBuilder.DropTable(
                name: "att_payloadeffectpunch");

            migrationBuilder.DropTable(
                name: "att_payloadexception");

            migrationBuilder.DropTable(
                name: "att_payloadmulpunchset");

            migrationBuilder.DropTable(
                name: "att_payloadovertime");

            migrationBuilder.DropTable(
                name: "att_payloadparing");

            migrationBuilder.DropTable(
                name: "att_payloadpaycode");

            migrationBuilder.DropTable(
                name: "att_payloadpunch");

            migrationBuilder.DropTable(
                name: "att_payloadtimecard");

            migrationBuilder.DropTable(
                name: "att_reportparam");

            migrationBuilder.DropTable(
                name: "att_reporttemplate");

            migrationBuilder.DropTable(
                name: "att_shiftdetail");

            migrationBuilder.DropTable(
                name: "att_temporaryschedule");

            migrationBuilder.DropTable(
                name: "att_tempschedule");

            migrationBuilder.DropTable(
                name: "att_timeinterval_break_time");

            migrationBuilder.DropTable(
                name: "att_training");

            migrationBuilder.DropTable(
                name: "att_webpunch");

            migrationBuilder.DropTable(
                name: "attparam");

            migrationBuilder.DropTable(
                name: "audit");

            migrationBuilder.DropTable(
                name: "auth_group_permissions");

            migrationBuilder.DropTable(
                name: "auth_user_auth_area");

            migrationBuilder.DropTable(
                name: "auth_user_auth_dept");

            migrationBuilder.DropTable(
                name: "auth_user_groups");

            migrationBuilder.DropTable(
                name: "auth_user_profile");

            migrationBuilder.DropTable(
                name: "auth_user_user_permissions");

            migrationBuilder.DropTable(
                name: "authtoken_token");

            migrationBuilder.DropTable(
                name: "base_adminlog");

            migrationBuilder.DropTable(
                name: "base_attparamdepts");

            migrationBuilder.DropTable(
                name: "base_autoattexporttask");

            migrationBuilder.DropTable(
                name: "base_autoexporttask");

            migrationBuilder.DropTable(
                name: "base_autoimporttask");

            migrationBuilder.DropTable(
                name: "base_bookmark");

            migrationBuilder.DropTable(
                name: "base_dbbackuplog");

            migrationBuilder.DropTable(
                name: "base_emailtemplate");

            migrationBuilder.DropTable(
                name: "base_eventalertsetting");

            migrationBuilder.DropTable(
                name: "base_fixedexporttask");

            migrationBuilder.DropTable(
                name: "base_linenotifysetting");

            migrationBuilder.DropTable(
                name: "base_securitypolicy");

            migrationBuilder.DropTable(
                name: "base_sendemail");

            migrationBuilder.DropTable(
                name: "base_sftpsetting");

            migrationBuilder.DropTable(
                name: "base_sysparam");

            migrationBuilder.DropTable(
                name: "base_sysparamdept");

            migrationBuilder.DropTable(
                name: "base_systemlog");

            migrationBuilder.DropTable(
                name: "base_systemsetting");

            migrationBuilder.DropTable(
                name: "base_whatsapplog");

            migrationBuilder.DropTable(
                name: "django_admin_log");

            migrationBuilder.DropTable(
                name: "django_celery_beat_periodictask");

            migrationBuilder.DropTable(
                name: "django_celery_beat_periodictasks");

            migrationBuilder.DropTable(
                name: "django_migrations");

            migrationBuilder.DropTable(
                name: "django_session");

            migrationBuilder.DropTable(
                name: "ep_epsetup");

            migrationBuilder.DropTable(
                name: "ep_eptransaction");

            migrationBuilder.DropTable(
                name: "guardian_groupobjectpermission");

            migrationBuilder.DropTable(
                name: "guardian_userobjectpermission");

            migrationBuilder.DropTable(
                name: "iclock_biodata");

            migrationBuilder.DropTable(
                name: "iclock_biophoto");

            migrationBuilder.DropTable(
                name: "iclock_devicemoduleconfig");

            migrationBuilder.DropTable(
                name: "iclock_errorcommandlog");

            migrationBuilder.DropTable(
                name: "iclock_privatemessage");

            migrationBuilder.DropTable(
                name: "iclock_publicmessage");

            migrationBuilder.DropTable(
                name: "iclock_terminalcommand");

            migrationBuilder.DropTable(
                name: "iclock_terminalcommandlog");

            migrationBuilder.DropTable(
                name: "iclock_terminalemployee");

            migrationBuilder.DropTable(
                name: "iclock_terminallog");

            migrationBuilder.DropTable(
                name: "iclock_terminalparameter");

            migrationBuilder.DropTable(
                name: "iclock_terminaluploadlog");

            migrationBuilder.DropTable(
                name: "iclock_terminalworkcode");

            migrationBuilder.DropTable(
                name: "iclock_transactionproofcmd");

            migrationBuilder.DropTable(
                name: "meeting_meetingentity_attender");

            migrationBuilder.DropTable(
                name: "meeting_meetingmanuallog");

            migrationBuilder.DropTable(
                name: "meeting_meetingpayloadbase");

            migrationBuilder.DropTable(
                name: "meeting_meetingroomdevice");

            migrationBuilder.DropTable(
                name: "meeting_meetingtransaction");

            migrationBuilder.DropTable(
                name: "mobile_announcement");

            migrationBuilder.DropTable(
                name: "mobile_appactionlog");

            migrationBuilder.DropTable(
                name: "mobile_applist");

            migrationBuilder.DropTable(
                name: "mobile_appnotification");

            migrationBuilder.DropTable(
                name: "mobile_gpsfordepartment_location");

            migrationBuilder.DropTable(
                name: "mobile_gpsforemployee_location");

            migrationBuilder.DropTable(
                name: "mobile_mobileapirequestlog");

            migrationBuilder.DropTable(
                name: "payroll_emploan");

            migrationBuilder.DropTable(
                name: "payroll_emppayrollprofile");

            migrationBuilder.DropTable(
                name: "payroll_extradeduction");

            migrationBuilder.DropTable(
                name: "payroll_extraincrease");

            migrationBuilder.DropTable(
                name: "payroll_payrollpayloadpaycode");

            migrationBuilder.DropTable(
                name: "payroll_reimbursement");

            migrationBuilder.DropTable(
                name: "payroll_salaryadvance");

            migrationBuilder.DropTable(
                name: "payroll_salarystructure_deductionformula");

            migrationBuilder.DropTable(
                name: "payroll_salarystructure_exceptionformula");

            migrationBuilder.DropTable(
                name: "payroll_salarystructure_increasementformula");

            migrationBuilder.DropTable(
                name: "payroll_salarystructure_leaveformula");

            migrationBuilder.DropTable(
                name: "payroll_salarystructure_overtimeformula");

            migrationBuilder.DropTable(
                name: "personnel_assignareaemployee");

            migrationBuilder.DropTable(
                name: "personnel_employee_area");

            migrationBuilder.DropTable(
                name: "personnel_employee_flow_role");

            migrationBuilder.DropTable(
                name: "personnel_employeecalendar");

            migrationBuilder.DropTable(
                name: "personnel_employeecertification");

            migrationBuilder.DropTable(
                name: "personnel_employeecustomattribute");

            migrationBuilder.DropTable(
                name: "personnel_employeeextrainfo");

            migrationBuilder.DropTable(
                name: "personnel_employeeprofile");

            migrationBuilder.DropTable(
                name: "personnel_employment");

            migrationBuilder.DropTable(
                name: "personnel_resign");

            migrationBuilder.DropTable(
                name: "rest_framework_tracking_apirequestlog");

            migrationBuilder.DropTable(
                name: "staff_stafftoken");

            migrationBuilder.DropTable(
                name: "sync_area");

            migrationBuilder.DropTable(
                name: "sync_department");

            migrationBuilder.DropTable(
                name: "sync_employee");

            migrationBuilder.DropTable(
                name: "sync_job");

            migrationBuilder.DropTable(
                name: "visitor_reservation");

            migrationBuilder.DropTable(
                name: "visitor_visitor_acc_groups");

            migrationBuilder.DropTable(
                name: "visitor_visitor_area");

            migrationBuilder.DropTable(
                name: "visitor_visitorbiodata");

            migrationBuilder.DropTable(
                name: "visitor_visitorbiophoto");

            migrationBuilder.DropTable(
                name: "visitor_visitorconfig");

            migrationBuilder.DropTable(
                name: "visitor_visitorlog");

            migrationBuilder.DropTable(
                name: "visitor_visitortransaction");

            migrationBuilder.DropTable(
                name: "workflow_nodeinstance");

            migrationBuilder.DropTable(
                name: "workflow_workflowengine_employee");

            migrationBuilder.DropTable(
                name: "workflow_workflownode_approver");

            migrationBuilder.DropTable(
                name: "workflow_workflownode_notifier");

            migrationBuilder.DropTable(
                name: "att_holiday");

            migrationBuilder.DropTable(
                name: "acc_acctimezone");

            migrationBuilder.DropTable(
                name: "att_leavegroup");

            migrationBuilder.DropTable(
                name: "att_attcode");

            migrationBuilder.DropTable(
                name: "att_leave");

            migrationBuilder.DropTable(
                name: "iclock_transaction");

            migrationBuilder.DropTable(
                name: "att_attshift");

            migrationBuilder.DropTable(
                name: "att_breaktime");

            migrationBuilder.DropTable(
                name: "att_timeinterval");

            migrationBuilder.DropTable(
                name: "django_celery_beat_clockedschedule");

            migrationBuilder.DropTable(
                name: "django_celery_beat_crontabschedule");

            migrationBuilder.DropTable(
                name: "django_celery_beat_intervalschedule");

            migrationBuilder.DropTable(
                name: "django_celery_beat_solarschedule");

            migrationBuilder.DropTable(
                name: "auth_group");

            migrationBuilder.DropTable(
                name: "auth_permission");

            migrationBuilder.DropTable(
                name: "iclock_shortmessage");

            migrationBuilder.DropTable(
                name: "meeting_meetingentity");

            migrationBuilder.DropTable(
                name: "mobile_gpsfordepartment");

            migrationBuilder.DropTable(
                name: "mobile_gpsforemployee");

            migrationBuilder.DropTable(
                name: "mobile_gpslocation");

            migrationBuilder.DropTable(
                name: "payroll_payrollpayload");

            migrationBuilder.DropTable(
                name: "payroll_deductionformula");

            migrationBuilder.DropTable(
                name: "payroll_exceptionformula");

            migrationBuilder.DropTable(
                name: "payroll_increasementformula");

            migrationBuilder.DropTable(
                name: "payroll_leaveformula");

            migrationBuilder.DropTable(
                name: "payroll_overtimeformula");

            migrationBuilder.DropTable(
                name: "payroll_salarystructure");

            migrationBuilder.DropTable(
                name: "auth_user");

            migrationBuilder.DropTable(
                name: "acc_accgroups");

            migrationBuilder.DropTable(
                name: "visitor_visitor");

            migrationBuilder.DropTable(
                name: "workflow_workflownode");

            migrationBuilder.DropTable(
                name: "workflow_workflowrole");

            migrationBuilder.DropTable(
                name: "att_attgroup");

            migrationBuilder.DropTable(
                name: "iclock_terminal");

            migrationBuilder.DropTable(
                name: "meeting_meetingroom");

            migrationBuilder.DropTable(
                name: "workflow_workflowinstance");

            migrationBuilder.DropTable(
                name: "att_paycode");

            migrationBuilder.DropTable(
                name: "personnel_certification");

            migrationBuilder.DropTable(
                name: "visitor_reason");

            migrationBuilder.DropTable(
                name: "personnel_area");

            migrationBuilder.DropTable(
                name: "workflow_workflowengine");

            migrationBuilder.DropTable(
                name: "django_content_type");

            migrationBuilder.DropTable(
                name: "personnel_employee");

            migrationBuilder.DropTable(
                name: "personnel_department");

            migrationBuilder.DropTable(
                name: "personnel_position");

            migrationBuilder.DropTable(
                name: "personnel_company");
        }
    }
}
