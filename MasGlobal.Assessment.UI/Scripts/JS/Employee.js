$(document).ready(function () {
    $("#searchEmployee").click(function () {
        ShowModal();
        let employeeId = $("#idEmployee").val();
        GetEmployees(employeeId);
    });
});

async function GetEmployees(employeeId) {
    //$("#tbodyEmployees").html('<tr><td colspan = "5" class= "text-center" > No Records</td ></tr>');
    $("#tbodyEmployees").html('');
    try {
        await fetch('/api/employee/' + employeeId)
            .then(function (responseData) {
                console.log(responseData);
                return responseData.json();
            }
            ).then(function (response) {
                if (response.status === true) {
                    DrawRecord(response.employees);
                } else {
                    swal("Error", response.message, "error");
                }
                HideModal();
                
            }
            ).catch(function (error) {
                swal("Error", "Something is wrong", "error");
                HideModal();
            });

    } catch (err) {
        alert('falle');
        HideModal();
    }

}

function DrawRecord(records) {
    if (records !== undefined) {
        if (records.length > 0) {
            records.map(function (item) {
                let rowText = `<tr><td>${item.id}</td><td>${item.name}</td><td>${item.contractTypeName}</td><td>${item.roleName}</td><td>${item.anualSalary}</td></tr>`;
                $("#tbodyEmployees").append(rowText);
            });
            HideModal();
        }
    }
}

function ShowModal() {
    $("#modalLoader").removeClass("withOutModal").addClass("withModal");
};

function HideModal() {
    $("#modalLoader").removeClass("withModal").addClass("withOutModal");

};