$(function () {
    $("#SinavListe").on("click", ".SinavSil", function () {
        var btn = $(this);

        
            if (confirm("Silmek istediğinize emin misiniz ?"))
            {
                var id = btn.data("id");
                $.ajax({
                    type: "GET",
                    url: "/Sinav/Sil/" + id,
                    success: function () {
                        btn.parent().parent().remove();
                    }

                });
            }

    });
});