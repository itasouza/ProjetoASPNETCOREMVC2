$(".escolherMes").on('change', function () {
    var mesId = $(".escolherMes").val();

    $.ajax({
        url: "Despesa/GestaoTotalMes",
        method: "POST",
        data: { mesId: mesId },
        success: function (dados) {
            $("canvas#GraficoGastoTotalMes").remove();
            $("div.GraficoGastoTotalMes").append('<canvas id="GraficoGastoTotalMes" style="width:300px;height:300px;"></canvas>');

            var ctx = document.getElementById("GraficoGastoTotalMes").getContext("2d");
            var grafico = new Chart(ctx, {
                type: 'doughnut',
                data:
                {
                    labels: ["Restante", "Total Gasto"],
                    datasets: [
                        {
                            label: "Total gasto",
                            backgroundColor: ["#27ae60", "#c0392b"],
                            data: [(dados.salario - dados.valorTotalGasto), dados.valorTotalGasto]
                        }
                    ]
                },
                options: {
                    responsive: false,
                    title: {
                        display: true,
                        text:"Total gasto no Mês"
                    }
                }
            });
        }
    });
});



function CarregarDadosGastosTotaisMes() {

    var mesId = $(".escolherMes").val();

    $.ajax({
        url: "Despesa/GestaoTotalMes",
        method: "POST",
        data: { mesId: 1 },
        success: function (dados) {
            $("canvas#GraficoGastoTotalMes").remove();
            $("div.GraficoGastoTotalMes").append('<canvas id="GraficoGastoTotalMes" style="width:300px;height:300px;"></canvas>');

            var ctx = document.getElementById("GraficoGastoTotalMes").getContext("2d");
            var grafico = new Chart(ctx, {
                type: 'doughnut',
                data:
                {
                    labels: ["Restante", "Total Gasto"],
                    datasets: [
                        {
                            label: "Total gasto",
                            backgroundColor: ["#27ae60", "#c0392b"],
                            data: [(dados.salario - dados.valorTotalGasto), dados.valorTotalGasto]
                        }
                    ]
                },
                options: {
                    responsive: false,
                    title: {
                        display: true,
                        text: "Total gasto no Mês"
                    }
                }
            });
        }
    });
}
