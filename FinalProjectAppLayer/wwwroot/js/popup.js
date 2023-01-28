
        var options = {
            autoClose: true,
            progressBar: true,
            enableSounds: true,
        };
        var toast = new Toasty(options);
        toast.configure(options);

    function SuccsesMessage(name) {

        $('#infotoast').ready(function () {

            toast.info(name + " Has been add successfully");

        });
}
function CommentSuccsess(name) {

    $('#infotoast').ready(function () {

        toast.success(name + " Has been add successfully");

    });
}
function RemoveCommentt(name) {
    $('#errortoast').ready(function () {

        toast.error(name + " Has been Removed ");

    });
}
        function RemoveFunction(name) {
            $('#errortoast').ready(function () {

                toast.error(name + " Has been Removed ");

            });
        }
        function WorkMessageRejected(name) {
        $('#errortoast').ready(function () {

            toast.error(name + " Has been Rejected successful ");

        });
            }
        function EditMessage(name) {
                   $('#successtoast').ready(function () {

                toast.success(name + " Has been update successfully");

            });
                }
            function WorkMessageApprove(name) {
                $('#successtoast').ready(function () {

                    toast.success(name + " Has been Approved successfully");

        });
                }




        


