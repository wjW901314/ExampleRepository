$("#openEmrSee").click(function () {
    var param = {
        "zyId": "3ace8cfe272980811055",
        "doctorId": "YG_092",
        "departmentId": "fc67f92b0051e47c1490",
        "orgId": "RSS20161209000000001",
        "serviceUrl": "http://10.158.5.13:8888"
    };
    var paramStr = JSON.stringify(param);
    window.location = "/Home/EmrSee?param=" + paramStr;
});
