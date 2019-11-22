$("#openEmrSee").click(function () {
    var param = {
        "zyId": "3ace8cfe272980811055",
        "doctorId": "YG_092",
        "doctorName": "王麻子",
        "departmentId": "fc67f92b0051e47c1490",
        "departmentName": "ICU ",
        "orgId": "RSS20161209000000001",
        "orgName": "南江县人民医院",
        "serviceUrl": "http://10.158.5.13:8888"
    };
    var paramStr = JSON.stringify(param);
    window.location = "/Home/EmrSee?param=" + paramStr;
});
