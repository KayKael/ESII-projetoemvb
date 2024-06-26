Imports System

Public Class ValoresPropostos
public ValoresDistribuidos as ValoresDistribuidos
public antigoContrato as Contrato
public novoContrato as Contrato

    Public Sub New()
    End Sub

    Public id_proposto As Integer
    Public servico As Integer
    Public valor_proposto As Double
    Public valor_contrato As Double
    Public percentagem_proposta As Single
    Public percentagem_exec As Single
    Public execucao_material As Double

    Public Function calcular_eficiencia_distribuicao() As Double
        ValoresDistribuidos.GetExecucaoMaterial() = execucao_material
        Contrato.GetValorDoContrato() = valor_contrato
        percentagem_exec = (valor_contrato * 100)/ execucao_material

        Return percentagem_exec
    End Function

    Public Function calcular_valor_proposto() As Double
        novoContrato.GetValorDoContrato() = valor_contrato
        percentagem_proposta= (percentagem_exec/100)
        valor_proposto = (valor_contrato * percentagem_proposta) 
        

        Return valor_proposto
    End Function

    Public Property GetIdProposto() As Integer
        Return id_proposto
    End Property

    Public Property SetIdProposto(ByVal value As Integer)
        id_proposto = value
    End Property

    Public Property GetServico() As Integer
        Return servico
    End Property

    Public Property SetServico(ByVal value As Integer)
        servico = value
    End Property

    Public Property GetValorProposto() As Double
        Return valor_proposto
    End Property

    Public Property SetValorProposto(ByVal value As Double)
        valor_proposto = value
    End Property

    Public Property GetPercentagemProposta() As Single
        Return percentagem_proposta
    End Property

    Public Property SetPercentagemProposta(ByVal value As Single)
        percentagem_proposta = value
    End Property

    Public Property GetPercentagemExec() As Single
        Return percentagem_exec
    End Property

    Public Property SetPercentagemExec(ByVal value As Single)
        percentagem_exec = value
    End Property

    Public Property GetExecucaoMaterial() As Double
        Return execucao_material
    End Property

    Public Property SetExecucaoMaterial(ByVal value As Double)
        execucao_material = value
    End Property

End Class
