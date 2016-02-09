Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System



Public Class mdtna0204
    Inherits GrapeCity.ActiveReports.SectionReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
    Private Label As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private lblTanaDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private txtGaichuCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private txtGaichuName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private linUnder As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line22 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line27 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line28 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line29 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line30 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line31 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line32 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line33 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line34 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line35 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line36 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line37 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line38 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line39 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line40 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line41 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line42 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line43 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line44 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line45 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line46 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line47 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line48 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line49 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line50 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line51 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line52 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line53 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line54 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line55 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line56 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line57 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line58 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line59 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line60 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line61 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line62 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line63 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line64 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line65 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line66 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line67 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line68 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line69 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line70 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line71 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line72 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line73 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line74 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line75 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line76 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line77 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line78 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line79 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line80 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line81 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line82 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line83 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line84 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line85 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line86 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line87 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line88 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line89 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line90 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line91 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line92 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line93 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line94 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line95 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line96 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line97 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line98 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line99 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line100 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line101 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line102 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line103 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line104 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line105 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line106 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line107 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line108 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line109 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line110 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line111 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line112 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line113 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line114 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line115 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line116 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line117 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line118 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line119 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line120 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line121 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line122 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line123 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line124 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line125 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line126 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line127 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line128 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line129 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line130 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line131 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line132 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line133 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line134 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line135 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line136 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line137 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line138 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line139 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line140 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line141 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line142 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line143 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line144 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line145 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line146 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line147 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line148 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line149 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line150 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line151 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line152 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line153 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line154 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line155 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line156 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line157 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line158 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line159 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line160 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line161 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line162 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line163 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line164 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line165 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line166 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line167 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line168 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line169 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line170 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line171 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line172 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line173 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line174 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line175 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line176 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line177 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line178 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line179 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line180 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line181 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line182 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line183 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line184 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line185 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line186 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line187 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line188 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line189 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line190 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line191 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line192 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line193 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line194 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line195 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line196 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line197 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line198 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line199 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line200 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line201 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line202 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line203 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line204 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line205 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line206 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line207 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line208 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line209 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line210 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line211 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line212 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line213 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line214 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line215 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line216 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line217 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line218 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line219 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line220 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line221 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line222 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line223 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line224 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line225 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line226 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line227 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line228 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line229 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line230 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line231 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line232 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line233 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line234 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line235 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line236 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line237 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line238 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line239 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line240 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line241 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line242 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line243 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line244 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line245 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line246 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line247 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line248 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line249 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line250 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line251 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line252 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line253 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line254 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line255 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line256 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line257 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line258 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line259 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line260 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line261 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line262 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line263 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line264 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line265 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line266 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line267 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line268 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line269 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line270 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line271 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line272 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line273 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line274 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line275 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line276 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line277 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line278 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line279 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line280 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line281 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line282 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line283 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line284 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line285 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line286 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line287 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line288 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line289 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line290 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line291 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line292 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line293 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line294 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line295 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line296 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line297 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line298 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line299 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line300 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line301 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line302 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line303 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line304 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line305 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line306 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line307 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line308 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line309 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line310 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line311 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line312 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line313 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line314 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line315 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line316 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line317 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line318 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line319 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line320 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line321 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line322 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line323 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line324 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line325 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line326 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line327 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line328 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line329 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line330 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line331 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line332 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line333 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line334 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line335 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line336 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line337 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line338 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line339 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line340 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line341 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line342 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line343 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line344 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line345 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line346 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line347 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line348 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line349 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line350 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line351 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line352 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line353 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line354 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line355 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line356 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line357 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line358 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line359 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line360 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line361 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line362 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Line363 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private Sub InitializeComponent()
        Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdtna0204))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTanaDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGaichuCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGaichuName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.linUnder = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line22 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line27 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line28 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line29 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line30 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line31 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line32 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line33 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line34 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line35 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line36 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line37 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line38 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line39 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line40 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line41 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line42 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line43 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line44 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line45 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line46 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line47 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line48 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line49 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line50 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line51 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line52 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line53 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line54 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line55 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line56 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line57 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line58 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line59 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line60 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line61 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line62 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line63 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line64 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line65 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line66 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line67 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line68 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line69 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line70 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line71 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line72 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line73 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line74 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line75 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line76 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line77 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line78 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line79 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line80 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line81 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line82 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line83 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line84 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line85 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line86 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line87 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line88 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line89 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line90 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line91 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line92 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line93 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line94 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line95 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line96 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line97 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line98 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line99 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line100 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line101 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line102 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line103 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line104 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line105 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line106 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line107 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line108 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line109 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line110 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line111 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line112 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line113 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line114 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line115 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line116 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line117 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line118 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line119 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line120 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line121 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line122 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line123 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line124 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line125 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line126 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line127 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line128 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line129 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line130 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line131 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line132 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line133 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line134 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line135 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line136 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line137 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line138 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line139 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line140 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line141 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line142 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line143 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line144 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line145 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line146 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line147 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line148 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line149 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line150 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line151 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line152 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line153 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line154 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line155 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line156 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line157 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line158 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line159 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line160 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line161 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line162 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line163 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line164 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line165 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line166 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line167 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line168 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line169 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line170 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line171 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line172 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line173 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line174 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line175 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line176 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line177 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line178 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line179 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line180 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line181 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line182 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line183 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line184 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line185 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line186 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line187 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line188 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line189 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line190 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line191 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line192 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line193 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line194 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line195 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line196 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line197 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line198 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line199 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line200 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line201 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line202 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line203 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line204 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line205 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line206 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line207 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line208 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line209 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line210 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line211 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line212 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line213 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line214 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line215 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line216 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line217 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line218 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line219 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line220 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line221 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line222 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line223 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line224 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line225 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line226 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line227 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line228 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line229 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line230 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line231 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line232 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line233 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line234 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line235 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line236 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line237 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line238 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line239 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line240 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line241 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line242 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line243 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line244 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line245 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line246 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line247 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line248 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line249 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line250 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line251 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line252 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line253 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line254 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line255 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line256 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line257 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line258 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line259 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line260 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line261 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line262 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line263 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line264 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line265 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line266 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line267 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line268 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line269 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line270 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line271 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line272 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line273 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line274 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line275 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line276 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line277 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line278 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line279 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line280 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line281 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line282 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line283 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line284 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line285 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line286 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line287 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line288 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line289 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line290 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line291 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line292 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line293 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line294 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line295 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line296 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line297 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line298 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line299 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line300 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line301 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line302 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line303 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line304 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line305 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line306 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line307 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line308 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line309 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line310 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line311 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line312 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line313 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line314 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line315 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line316 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line317 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line318 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line319 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line320 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line321 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line322 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line323 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line324 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line325 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line326 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line327 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line328 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line329 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line330 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line331 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line332 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line333 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line334 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line335 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line336 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line337 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line338 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line339 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line340 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line341 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line342 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line343 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line344 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line345 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line346 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line347 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line348 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line349 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line350 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line351 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line352 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line353 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line354 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line355 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line356 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line357 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line358 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line359 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line360 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line361 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line362 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line363 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGaichuCode, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtGaichuName, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line9, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line10, Me.linUnder, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line39, Me.Line40, Me.Line41, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Line46, Me.Line47, Me.Line48, Me.Line49, Me.Line50, Me.Line51, Me.Line52, Me.Line53, Me.Line54, Me.Line55, Me.Line56, Me.Line57, Me.Line58, Me.Line59, Me.Line60, Me.Line61, Me.Line62, Me.Line63, Me.Line64, Me.Line65, Me.Line66, Me.Line67, Me.Line68, Me.Line69, Me.Line70, Me.Line71, Me.Line72, Me.Line73, Me.Line74, Me.Line75, Me.Line76, Me.Line77, Me.Line78, Me.Line79, Me.Line80, Me.Line81, Me.Line82, Me.Line83, Me.Line84, Me.Line85, Me.Line86, Me.Line87, Me.Line88, Me.Line89, Me.Line90, Me.Line91, Me.Line92, Me.Line93, Me.Line94, Me.Line95, Me.Line96, Me.Line97, Me.Line98, Me.Line99, Me.Line100, Me.Line101, Me.Line102, Me.Line103, Me.Line104, Me.Line105, Me.Line106, Me.Line107, Me.Line108, Me.Line109, Me.Line110, Me.Line111, Me.Line112, Me.Line113, Me.Line114, Me.Line115, Me.Line116, Me.Line117, Me.Line118, Me.Line119, Me.Line120, Me.Line121, Me.Line122, Me.Line123, Me.Line124, Me.Line125, Me.Line126, Me.Line127, Me.Line128, Me.Line129, Me.Line130, Me.Line131, Me.Line132, Me.Line133, Me.Line134, Me.Line135, Me.Line136, Me.Line137, Me.Line138, Me.Line139, Me.Line140, Me.Line141, Me.Line142, Me.Line143, Me.Line144, Me.Line145, Me.Line146, Me.Line147, Me.Line148, Me.Line149, Me.Line150, Me.Line151, Me.Line152, Me.Line153, Me.Line154, Me.Line155, Me.Line156, Me.Line157, Me.Line158, Me.Line159, Me.Line160, Me.Line161, Me.Line162, Me.Line163, Me.Line164, Me.Line165, Me.Line166, Me.Line167, Me.Line168, Me.Line169, Me.Line170, Me.Line171, Me.Line172, Me.Line173, Me.Line174, Me.Line175, Me.Line176, Me.Line177, Me.Line178, Me.Line179, Me.Line180, Me.Line181, Me.Line182, Me.Line183, Me.Line184, Me.Line185, Me.Line186, Me.Line187, Me.Line188, Me.Line189, Me.Line190, Me.Line191, Me.Line192, Me.Line193, Me.Line194, Me.Line195, Me.Line196, Me.Line197, Me.Line198, Me.Line199, Me.Line200, Me.Line201, Me.Line202, Me.Line203, Me.Line204, Me.Line205, Me.Line206, Me.Line207, Me.Line208, Me.Line209, Me.Line210, Me.Line211, Me.Line212, Me.Line213, Me.Line214, Me.Line215, Me.Line216, Me.Line217, Me.Line218, Me.Line219, Me.Line220, Me.Line221, Me.Line222, Me.Line223, Me.Line224, Me.Line225, Me.Line226, Me.Line227, Me.Line228, Me.Line229, Me.Line230, Me.Line231, Me.Line232, Me.Line233, Me.Line234, Me.Line235, Me.Line236, Me.Line237, Me.Line238, Me.Line239, Me.Line240, Me.Line241, Me.Line242, Me.Line243, Me.Line244, Me.Line245, Me.Line246, Me.Line247, Me.Line248, Me.Line249, Me.Line250, Me.Line251, Me.Line252, Me.Line253, Me.Line254, Me.Line255, Me.Line256, Me.Line257, Me.Line258, Me.Line259, Me.Line260, Me.Line261, Me.Line262, Me.Line263, Me.Line264, Me.Line265, Me.Line266, Me.Line267, Me.Line268, Me.Line269, Me.Line270, Me.Line271, Me.Line272, Me.Line273, Me.Line274, Me.Line275, Me.Line276, Me.Line277, Me.Line278, Me.Line279, Me.Line280, Me.Line281, Me.Line282, Me.Line283, Me.Line284, Me.Line285, Me.Line286, Me.Line287, Me.Line288, Me.Line289, Me.Line290, Me.Line291, Me.Line292, Me.Line293, Me.Line294, Me.Line295, Me.Line296, Me.Line297, Me.Line298, Me.Line299, Me.Line300, Me.Line301, Me.Line302, Me.Line303, Me.Line304, Me.Line305, Me.Line306, Me.Line307, Me.Line308, Me.Line309, Me.Line310, Me.Line311, Me.Line312, Me.Line313, Me.Line314, Me.Line315, Me.Line316, Me.Line317, Me.Line318, Me.Line319, Me.Line320, Me.Line321, Me.Line322, Me.Line323, Me.Line324, Me.Line325, Me.Line326, Me.Line327, Me.Line328, Me.Line329, Me.Line330, Me.Line331, Me.Line332, Me.Line333, Me.Line334, Me.Line335, Me.Line336, Me.Line337, Me.Line338, Me.Line339, Me.Line340, Me.Line341, Me.Line342, Me.Line343, Me.Line344, Me.Line345, Me.Line346, Me.Line347, Me.Line348, Me.Line349, Me.Line350, Me.Line351, Me.Line352, Me.Line353, Me.Line354, Me.Line355, Me.Line356, Me.Line357, Me.Line358, Me.Line359, Me.Line360, Me.Line361, Me.Line362, Me.Line363})
        Me.Detail.Height = 8.541667!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label, Me.Label11, Me.lblDate, Me.Label12, Me.lblPage})
        Me.PageHeader.Height = 0.55!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label16, Me.Label17, Me.Label18, Me.Label19})
        Me.PageFooter.Height = 0.9375!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label15, Me.Label14, Me.Label13, Me.Label10, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label9, Me.lblTanaDate, Me.Label1, Me.Label2, Me.txtGaichuCode, Me.txtGaichuName, Me.Label3, Me.Line, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21})
        Me.GroupHeader1.DataField = "CONTRACTOUT_CD"
        Me.GroupHeader1.Height = 1.070139!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.Visible = false
        '
        'Label
        '
        Me.Label.Height = 0.2666667!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0!
        Me.Label.Name = "Label"
        Me.Label.Style = "font-family: ＭＳ ゴシック; font-size: 14.25pt; text-align: center; vertical-align: bot" & _
            "tom"
        Me.Label.Text = "※※※　仕掛棚卸表　※※※"
        Me.Label.Top = 0.06666667!
        Me.Label.Width = 7.333333!
        '
        'Label11
        '
        Me.Label11.Height = 0.2000001!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.866667!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label11.Text = "作成日："
        Me.Label11.Top = 0.1333333!
        Me.Label11.Width = 0.666666!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2000001!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 6.533333!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.lblDate.Text = "YYYY/MM/DD"
        Me.lblDate.Top = 0.1333333!
        Me.lblDate.Width = 0.8!
        '
        'Label12
        '
        Me.Label12.Height = 0.2000001!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 6.666667!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label12.Text = "PAGE."
        Me.Label12.Top = 0.3333334!
        Me.Label12.Width = 0.3999996!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2000001!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 7.066667!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.lblPage.Text = "999"
        Me.lblPage.Top = 0.3333333!
        Me.lblPage.Width = 0.2666664!
        '
        'Label15
        '
        Me.Label15.Height = 0.2666667!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 6.266663!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label15.Text = "発注日"
        Me.Label15.Top = 0.8!
        Me.Label15.Width = 1!
        '
        'Label14
        '
        Me.Label14.Height = 0.2666667!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 5.733331!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label14.Text = "工順"
        Me.Label14.Top = 0.8!
        Me.Label14.Width = 0.5333334!
        '
        'Label13
        '
        Me.Label13.Height = 0.2666667!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 5.199998!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label13.Text = "工程"
        Me.Label13.Top = 0.8!
        Me.Label13.Width = 0.5333334!
        '
        'Label10
        '
        Me.Label10.Height = 0.2666667!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.133333!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label10.Text = "出荷数"
        Me.Label10.Top = 0.8!
        Me.Label10.Width = 1.066667!
        '
        'Label8
        '
        Me.Label8.Height = 0.2666667!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.6!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label8.Text = "カタログ番号"
        Me.Label8.Top = 0.8!
        Me.Label8.Width = 1.533334!
        '
        'Label7
        '
        Me.Label7.Height = 0.2666667!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.333!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label7.Text = "社内NO"
        Me.Label7.Top = 0.8!
        Me.Label7.Width = 0.6666667!
        '
        'Label6
        '
        Me.Label6.Height = 0.2666667!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label6.Text = "指示NO"
        Me.Label6.Top = 0.8125!
        Me.Label6.Width = 0.6000001!
        '
        'Label5
        '
        Me.Label5.Height = 0.2666667!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.5333334!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label5.Text = "注文NO"
        Me.Label5.Top = 0.8!
        Me.Label5.Width = 0.8!
        '
        'Label4
        '
        Me.Label4.Height = 0.2666667!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.06666667!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align" & _
            ": center; vertical-align: bottom"
        Me.Label4.Text = "ﾁｪｯｸ"
        Me.Label4.Top = 0.8!
        Me.Label4.Width = 0.4666668!
        '
        'Label9
        '
        Me.Label9.Height = 0.2000001!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.06666667!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label9.Text = "棚卸日："
        Me.Label9.Top = 0.06666667!
        Me.Label9.Width = 0.666666!
        '
        'lblTanaDate
        '
        Me.lblTanaDate.Height = 0.2000001!
        Me.lblTanaDate.HyperLink = Nothing
        Me.lblTanaDate.Left = 0.7333333!
        Me.lblTanaDate.Name = "lblTanaDate"
        Me.lblTanaDate.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.lblTanaDate.Text = "YYYY年MM月DD日"
        Me.lblTanaDate.Top = 0.06666667!
        Me.lblTanaDate.Width = 1.2!
        '
        'Label1
        '
        Me.Label1.Height = 0.2000001!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 4.8!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label1.Text = "メイラ株式会社　メディカル生産部"
        Me.Label1.Top = 0.06666667!
        Me.Label1.Width = 2.599999!
        '
        'Label2
        '
        Me.Label2.Height = 0.2000001!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.06666667!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: right; vertical-align: bott" & _
            "om; white-space: nowrap"
        Me.Label2.Text = "コード："
        Me.Label2.Top = 0.2666667!
        Me.Label2.Width = 0.666666!
        '
        'txtGaichuCode
        '
        Me.txtGaichuCode.DataField = "CONTRACTOUT_CD"
        Me.txtGaichuCode.Height = 0.2!
        Me.txtGaichuCode.Left = 0.7333333!
        Me.txtGaichuCode.Name = "txtGaichuCode"
        Me.txtGaichuCode.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtGaichuCode.Text = "XXXX"
        Me.txtGaichuCode.Top = 0.2666667!
        Me.txtGaichuCode.Width = 0.3999999!
        '
        'txtGaichuName
        '
        Me.txtGaichuName.DataField = "CONTRACTOUT_NM"
        Me.txtGaichuName.Height = 0.2!
        Me.txtGaichuName.Left = 0.1333333!
        Me.txtGaichuName.Name = "txtGaichuName"
        Me.txtGaichuName.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; vertical-align: bottom"
        Me.txtGaichuName.Text = "ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ"
        Me.txtGaichuName.Top = 0.4666668!
        Me.txtGaichuName.Width = 2.4!
        '
        'Label3
        '
        Me.Label3.Height = 0.2000001!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.533333!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label3.Text = "御中　　社印"
        Me.Label3.Top = 0.4666668!
        Me.Label3.Width = 1!
        '
        'Line
        '
        Me.Line.Height = 0!
        Me.Line.Left = 0.1333333!
        Me.Line.LineWeight = 1!
        Me.Line.Name = "Line"
        Me.Line.Top = 0.6666667!
        Me.Line.Width = 3.4!
        Me.Line.X1 = 0.1333333!
        Me.Line.X2 = 3.533333!
        Me.Line.Y1 = 0.6666667!
        Me.Line.Y2 = 0.6666667!
        '
        'Line11
        '
        Me.Line11.Height = 0.2666667!
        Me.Line11.Left = 0.06666667!
        Me.Line11.LineWeight = 1!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.8!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 0.06666667!
        Me.Line11.X2 = 0.06666667!
        Me.Line11.Y1 = 0.8!
        Me.Line11.Y2 = 1.066667!
        '
        'Line12
        '
        Me.Line12.Height = 0.2666667!
        Me.Line12.Left = 0.5333334!
        Me.Line12.LineWeight = 1!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.8!
        Me.Line12.Width = 0!
        Me.Line12.X1 = 0.5333334!
        Me.Line12.X2 = 0.5333334!
        Me.Line12.Y1 = 0.8!
        Me.Line12.Y2 = 1.066667!
        '
        'Line13
        '
        Me.Line13.Height = 0.2666667!
        Me.Line13.Left = 1.333333!
        Me.Line13.LineWeight = 1!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.8!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 1.333333!
        Me.Line13.X2 = 1.333333!
        Me.Line13.Y1 = 0.8!
        Me.Line13.Y2 = 1.066667!
        '
        'Line14
        '
        Me.Line14.Height = 0.2666667!
        Me.Line14.Left = 1.995834!
        Me.Line14.LineWeight = 1!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.8!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 1.995834!
        Me.Line14.X2 = 1.995834!
        Me.Line14.Y1 = 0.8!
        Me.Line14.Y2 = 1.066667!
        '
        'Line15
        '
        Me.Line15.Height = 0.2666667!
        Me.Line15.Left = 2.6!
        Me.Line15.LineWeight = 1!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.8!
        Me.Line15.Width = 0!
        Me.Line15.X1 = 2.6!
        Me.Line15.X2 = 2.6!
        Me.Line15.Y1 = 0.8!
        Me.Line15.Y2 = 1.066667!
        '
        'Line16
        '
        Me.Line16.Height = 0.2666667!
        Me.Line16.Left = 4.133333!
        Me.Line16.LineWeight = 1!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.8!
        Me.Line16.Width = 0!
        Me.Line16.X1 = 4.133333!
        Me.Line16.X2 = 4.133333!
        Me.Line16.Y1 = 0.8!
        Me.Line16.Y2 = 1.066667!
        '
        'Line17
        '
        Me.Line17.Height = 0.2666667!
        Me.Line17.Left = 5.199998!
        Me.Line17.LineWeight = 1!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.8!
        Me.Line17.Width = 0!
        Me.Line17.X1 = 5.199998!
        Me.Line17.X2 = 5.199998!
        Me.Line17.Y1 = 0.8!
        Me.Line17.Y2 = 1.066667!
        '
        'Line18
        '
        Me.Line18.Height = 0.2666667!
        Me.Line18.Left = 5.733331!
        Me.Line18.LineWeight = 1!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.8!
        Me.Line18.Width = 0!
        Me.Line18.X1 = 5.733331!
        Me.Line18.X2 = 5.733331!
        Me.Line18.Y1 = 0.8!
        Me.Line18.Y2 = 1.066667!
        '
        'Line19
        '
        Me.Line19.Height = 0.2666667!
        Me.Line19.Left = 6.266664!
        Me.Line19.LineWeight = 1!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.8!
        Me.Line19.Width = 0!
        Me.Line19.X1 = 6.266664!
        Me.Line19.X2 = 6.266664!
        Me.Line19.Y1 = 0.8!
        Me.Line19.Y2 = 1.066667!
        '
        'Line20
        '
        Me.Line20.Height = 0.2666667!
        Me.Line20.Left = 7.26666!
        Me.Line20.LineWeight = 1!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.8!
        Me.Line20.Width = 0!
        Me.Line20.X1 = 7.26666!
        Me.Line20.X2 = 7.26666!
        Me.Line20.Y1 = 0.8!
        Me.Line20.Y2 = 1.066667!
        '
        'Line21
        '
        Me.Line21.Height = 0!
        Me.Line21.Left = 0.06666667!
        Me.Line21.LineWeight = 1!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.8!
        Me.Line21.Width = 7.2!
        Me.Line21.X1 = 0.06666667!
        Me.Line21.X2 = 7.266667!
        Me.Line21.Y1 = 0.8!
        Me.Line21.Y2 = 0.8!
        '
        'Line9
        '
        Me.Line9.Height = 0.2666667!
        Me.Line9.Left = 0.06666667!
        Me.Line9.LineWeight = 1!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 0.06666667!
        Me.Line9.X2 = 0.06666667!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0.2666667!
        '
        'Line1
        '
        Me.Line1.Height = 0.2666667!
        Me.Line1.Left = 0.5333334!
        Me.Line1.LineWeight = 1!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 0.5333334!
        Me.Line1.X2 = 0.5333334!
        Me.Line1.Y1 = 0!
        Me.Line1.Y2 = 0.2666667!
        '
        'Line2
        '
        Me.Line2.Height = 0.2666667!
        Me.Line2.Left = 1.333333!
        Me.Line2.LineWeight = 1!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 1.333333!
        Me.Line2.X2 = 1.333333!
        Me.Line2.Y1 = 0!
        Me.Line2.Y2 = 0.2666667!
        '
        'Line3
        '
        Me.Line3.Height = 0.2666667!
        Me.Line3.Left = 1.995834!
        Me.Line3.LineWeight = 1!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 1.995834!
        Me.Line3.X2 = 1.995834!
        Me.Line3.Y1 = 0!
        Me.Line3.Y2 = 0.2666667!
        '
        'Line4
        '
        Me.Line4.Height = 0.2666667!
        Me.Line4.Left = 2.6!
        Me.Line4.LineWeight = 1!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.6!
        Me.Line4.X2 = 2.6!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.2666667!
        '
        'Line5
        '
        Me.Line5.Height = 0.2666667!
        Me.Line5.Left = 4.133333!
        Me.Line5.LineWeight = 1!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 7.450583E-08!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 4.133333!
        Me.Line5.X2 = 4.133333!
        Me.Line5.Y1 = 7.450583E-08!
        Me.Line5.Y2 = 0.2666668!
        '
        'Line6
        '
        Me.Line6.Height = 0.2666668!
        Me.Line6.Left = 5.199998!
        Me.Line6.LineWeight = 1!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.639128E-07!
        Me.Line6.Width = 0!
        Me.Line6.X1 = 5.199998!
        Me.Line6.X2 = 5.199998!
        Me.Line6.Y1 = 1.639128E-07!
        Me.Line6.Y2 = 0.2666669!
        '
        'Line7
        '
        Me.Line7.Height = 0.2666668!
        Me.Line7.Left = 5.733331!
        Me.Line7.LineWeight = 1!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 5.733331!
        Me.Line7.X2 = 5.733331!
        Me.Line7.Y1 = 0!
        Me.Line7.Y2 = 0.2666668!
        '
        'Line8
        '
        Me.Line8.Height = 0.2666668!
        Me.Line8.Left = 6.266663!
        Me.Line8.LineWeight = 1!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.043081E-07!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 6.266663!
        Me.Line8.X2 = 6.266663!
        Me.Line8.Y1 = 1.043081E-07!
        Me.Line8.Y2 = 0.2666669!
        '
        'Line10
        '
        Me.Line10.Height = 0.2666668!
        Me.Line10.Left = 7.26666!
        Me.Line10.LineWeight = 1!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 7.26666!
        Me.Line10.X2 = 7.26666!
        Me.Line10.Y1 = 0!
        Me.Line10.Y2 = 0.2666668!
        '
        'linUnder
        '
        Me.linUnder.Height = 0!
        Me.linUnder.Left = 0.06666667!
        Me.linUnder.LineWeight = 1!
        Me.linUnder.Name = "linUnder"
        Me.linUnder.Top = 0.2666667!
        Me.linUnder.Width = 7.2!
        Me.linUnder.X1 = 0.06666667!
        Me.linUnder.X2 = 7.266667!
        Me.linUnder.Y1 = 0.2666667!
        Me.linUnder.Y2 = 0.2666667!
        '
        'Line22
        '
        Me.Line22.Height = 0.2666667!
        Me.Line22.Left = 0.06666667!
        Me.Line22.LineWeight = 1!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0.2666667!
        Me.Line22.Width = 0!
        Me.Line22.X1 = 0.06666667!
        Me.Line22.X2 = 0.06666667!
        Me.Line22.Y1 = 0.2666667!
        Me.Line22.Y2 = 0.5333334!
        '
        'Line23
        '
        Me.Line23.Height = 0.2666667!
        Me.Line23.Left = 0.5333334!
        Me.Line23.LineWeight = 1!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0.2666667!
        Me.Line23.Width = 0!
        Me.Line23.X1 = 0.5333334!
        Me.Line23.X2 = 0.5333334!
        Me.Line23.Y1 = 0.2666667!
        Me.Line23.Y2 = 0.5333334!
        '
        'Line24
        '
        Me.Line24.Height = 0.2666667!
        Me.Line24.Left = 1.333333!
        Me.Line24.LineWeight = 1!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0.2666667!
        Me.Line24.Width = 0!
        Me.Line24.X1 = 1.333333!
        Me.Line24.X2 = 1.333333!
        Me.Line24.Y1 = 0.2666667!
        Me.Line24.Y2 = 0.5333334!
        '
        'Line25
        '
        Me.Line25.Height = 0.2666667!
        Me.Line25.Left = 1.995834!
        Me.Line25.LineWeight = 1!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.2666667!
        Me.Line25.Width = 0!
        Me.Line25.X1 = 1.995834!
        Me.Line25.X2 = 1.995834!
        Me.Line25.Y1 = 0.2666667!
        Me.Line25.Y2 = 0.5333334!
        '
        'Line26
        '
        Me.Line26.Height = 0.2666667!
        Me.Line26.Left = 2.6!
        Me.Line26.LineWeight = 1!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.2666667!
        Me.Line26.Width = 0!
        Me.Line26.X1 = 2.6!
        Me.Line26.X2 = 2.6!
        Me.Line26.Y1 = 0.2666667!
        Me.Line26.Y2 = 0.5333334!
        '
        'Line27
        '
        Me.Line27.Height = 0.2666667!
        Me.Line27.Left = 4.133333!
        Me.Line27.LineWeight = 1!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 0.2666667!
        Me.Line27.Width = 0!
        Me.Line27.X1 = 4.133333!
        Me.Line27.X2 = 4.133333!
        Me.Line27.Y1 = 0.2666667!
        Me.Line27.Y2 = 0.5333335!
        '
        'Line28
        '
        Me.Line28.Height = 0.2666668!
        Me.Line28.Left = 5.199998!
        Me.Line28.LineWeight = 1!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 0.2666668!
        Me.Line28.Width = 0!
        Me.Line28.X1 = 5.199998!
        Me.Line28.X2 = 5.199998!
        Me.Line28.Y1 = 0.2666668!
        Me.Line28.Y2 = 0.5333337!
        '
        'Line29
        '
        Me.Line29.Height = 0.2666668!
        Me.Line29.Left = 5.733331!
        Me.Line29.LineWeight = 1!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 0.2666667!
        Me.Line29.Width = 0!
        Me.Line29.X1 = 5.733331!
        Me.Line29.X2 = 5.733331!
        Me.Line29.Y1 = 0.2666667!
        Me.Line29.Y2 = 0.5333335!
        '
        'Line30
        '
        Me.Line30.Height = 0.2666668!
        Me.Line30.Left = 6.266663!
        Me.Line30.LineWeight = 1!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0.2666668!
        Me.Line30.Width = 0!
        Me.Line30.X1 = 6.266663!
        Me.Line30.X2 = 6.266663!
        Me.Line30.Y1 = 0.2666668!
        Me.Line30.Y2 = 0.5333337!
        '
        'Line31
        '
        Me.Line31.Height = 0.2666668!
        Me.Line31.Left = 7.26666!
        Me.Line31.LineWeight = 1!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 0.2666667!
        Me.Line31.Width = 0!
        Me.Line31.X1 = 7.26666!
        Me.Line31.X2 = 7.26666!
        Me.Line31.Y1 = 0.2666667!
        Me.Line31.Y2 = 0.5333335!
        '
        'Line32
        '
        Me.Line32.Height = 0!
        Me.Line32.Left = 0.06666667!
        Me.Line32.LineWeight = 1!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 0.5333334!
        Me.Line32.Width = 7.2!
        Me.Line32.X1 = 0.06666667!
        Me.Line32.X2 = 7.266667!
        Me.Line32.Y1 = 0.5333334!
        Me.Line32.Y2 = 0.5333334!
        '
        'Line33
        '
        Me.Line33.Height = 0.2666666!
        Me.Line33.Left = 0.06666667!
        Me.Line33.LineWeight = 1!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0.5333334!
        Me.Line33.Width = 0!
        Me.Line33.X1 = 0.06666667!
        Me.Line33.X2 = 0.06666667!
        Me.Line33.Y1 = 0.5333334!
        Me.Line33.Y2 = 0.8!
        '
        'Line34
        '
        Me.Line34.Height = 0.2666666!
        Me.Line34.Left = 0.5333334!
        Me.Line34.LineWeight = 1!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 0.5333334!
        Me.Line34.Width = 0!
        Me.Line34.X1 = 0.5333334!
        Me.Line34.X2 = 0.5333334!
        Me.Line34.Y1 = 0.5333334!
        Me.Line34.Y2 = 0.8!
        '
        'Line35
        '
        Me.Line35.Height = 0.2666666!
        Me.Line35.Left = 1.333333!
        Me.Line35.LineWeight = 1!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 0.5333334!
        Me.Line35.Width = 0!
        Me.Line35.X1 = 1.333333!
        Me.Line35.X2 = 1.333333!
        Me.Line35.Y1 = 0.5333334!
        Me.Line35.Y2 = 0.8!
        '
        'Line36
        '
        Me.Line36.Height = 0.2666666!
        Me.Line36.Left = 1.995834!
        Me.Line36.LineWeight = 1!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 0.5333334!
        Me.Line36.Width = 0!
        Me.Line36.X1 = 1.995834!
        Me.Line36.X2 = 1.995834!
        Me.Line36.Y1 = 0.5333334!
        Me.Line36.Y2 = 0.8!
        '
        'Line37
        '
        Me.Line37.Height = 0.2666666!
        Me.Line37.Left = 2.6!
        Me.Line37.LineWeight = 1!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 0.5333334!
        Me.Line37.Width = 0!
        Me.Line37.X1 = 2.6!
        Me.Line37.X2 = 2.6!
        Me.Line37.Y1 = 0.5333334!
        Me.Line37.Y2 = 0.8!
        '
        'Line38
        '
        Me.Line38.Height = 0.2666666!
        Me.Line38.Left = 4.133333!
        Me.Line38.LineWeight = 1!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 0.5333334!
        Me.Line38.Width = 0!
        Me.Line38.X1 = 4.133333!
        Me.Line38.X2 = 4.133333!
        Me.Line38.Y1 = 0.5333334!
        Me.Line38.Y2 = 0.8!
        '
        'Line39
        '
        Me.Line39.Height = 0.2666665!
        Me.Line39.Left = 5.199998!
        Me.Line39.LineWeight = 1!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 0.5333335!
        Me.Line39.Width = 0!
        Me.Line39.X1 = 5.199998!
        Me.Line39.X2 = 5.199998!
        Me.Line39.Y1 = 0.5333335!
        Me.Line39.Y2 = 0.8!
        '
        'Line40
        '
        Me.Line40.Height = 0.2666666!
        Me.Line40.Left = 5.733331!
        Me.Line40.LineWeight = 1!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 0.5333334!
        Me.Line40.Width = 0!
        Me.Line40.X1 = 5.733331!
        Me.Line40.X2 = 5.733331!
        Me.Line40.Y1 = 0.5333334!
        Me.Line40.Y2 = 0.8!
        '
        'Line41
        '
        Me.Line41.Height = 0.2666666!
        Me.Line41.Left = 6.266663!
        Me.Line41.LineWeight = 1!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 0.5333334!
        Me.Line41.Width = 0!
        Me.Line41.X1 = 6.266663!
        Me.Line41.X2 = 6.266663!
        Me.Line41.Y1 = 0.5333334!
        Me.Line41.Y2 = 0.8!
        '
        'Line42
        '
        Me.Line42.Height = 0.2666666!
        Me.Line42.Left = 7.26666!
        Me.Line42.LineWeight = 1!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0.5333334!
        Me.Line42.Width = 0!
        Me.Line42.X1 = 7.26666!
        Me.Line42.X2 = 7.26666!
        Me.Line42.Y1 = 0.5333334!
        Me.Line42.Y2 = 0.8!
        '
        'Line43
        '
        Me.Line43.Height = 0!
        Me.Line43.Left = 0.06666667!
        Me.Line43.LineWeight = 1!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 0.8!
        Me.Line43.Width = 7.2!
        Me.Line43.X1 = 0.06666667!
        Me.Line43.X2 = 7.266667!
        Me.Line43.Y1 = 0.8!
        Me.Line43.Y2 = 0.8!
        '
        'Line44
        '
        Me.Line44.Height = 0.2666667!
        Me.Line44.Left = 0.06666667!
        Me.Line44.LineWeight = 1!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 0.8!
        Me.Line44.Width = 0!
        Me.Line44.X1 = 0.06666667!
        Me.Line44.X2 = 0.06666667!
        Me.Line44.Y1 = 0.8!
        Me.Line44.Y2 = 1.066667!
        '
        'Line45
        '
        Me.Line45.Height = 0.2666667!
        Me.Line45.Left = 0.5333334!
        Me.Line45.LineWeight = 1!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 0.8!
        Me.Line45.Width = 0!
        Me.Line45.X1 = 0.5333334!
        Me.Line45.X2 = 0.5333334!
        Me.Line45.Y1 = 0.8!
        Me.Line45.Y2 = 1.066667!
        '
        'Line46
        '
        Me.Line46.Height = 0.2666667!
        Me.Line46.Left = 1.333333!
        Me.Line46.LineWeight = 1!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 0.8!
        Me.Line46.Width = 0!
        Me.Line46.X1 = 1.333333!
        Me.Line46.X2 = 1.333333!
        Me.Line46.Y1 = 0.8!
        Me.Line46.Y2 = 1.066667!
        '
        'Line47
        '
        Me.Line47.Height = 0.2666667!
        Me.Line47.Left = 1.995834!
        Me.Line47.LineWeight = 1!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 0.8!
        Me.Line47.Width = 0!
        Me.Line47.X1 = 1.995834!
        Me.Line47.X2 = 1.995834!
        Me.Line47.Y1 = 0.8!
        Me.Line47.Y2 = 1.066667!
        '
        'Line48
        '
        Me.Line48.Height = 0.2666667!
        Me.Line48.Left = 2.6!
        Me.Line48.LineWeight = 1!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 0.8!
        Me.Line48.Width = 0!
        Me.Line48.X1 = 2.6!
        Me.Line48.X2 = 2.6!
        Me.Line48.Y1 = 0.8!
        Me.Line48.Y2 = 1.066667!
        '
        'Line49
        '
        Me.Line49.Height = 0.2666667!
        Me.Line49.Left = 4.133333!
        Me.Line49.LineWeight = 1!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 0.8!
        Me.Line49.Width = 0!
        Me.Line49.X1 = 4.133333!
        Me.Line49.X2 = 4.133333!
        Me.Line49.Y1 = 0.8!
        Me.Line49.Y2 = 1.066667!
        '
        'Line50
        '
        Me.Line50.Height = 0.2666667!
        Me.Line50.Left = 5.199998!
        Me.Line50.LineWeight = 1!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 0.8!
        Me.Line50.Width = 0!
        Me.Line50.X1 = 5.199998!
        Me.Line50.X2 = 5.199998!
        Me.Line50.Y1 = 0.8!
        Me.Line50.Y2 = 1.066667!
        '
        'Line51
        '
        Me.Line51.Height = 0.2666667!
        Me.Line51.Left = 5.733331!
        Me.Line51.LineWeight = 1!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0.8!
        Me.Line51.Width = 0!
        Me.Line51.X1 = 5.733331!
        Me.Line51.X2 = 5.733331!
        Me.Line51.Y1 = 0.8!
        Me.Line51.Y2 = 1.066667!
        '
        'Line52
        '
        Me.Line52.Height = 0.2666667!
        Me.Line52.Left = 6.266663!
        Me.Line52.LineWeight = 1!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 0.8!
        Me.Line52.Width = 0!
        Me.Line52.X1 = 6.266663!
        Me.Line52.X2 = 6.266663!
        Me.Line52.Y1 = 0.8!
        Me.Line52.Y2 = 1.066667!
        '
        'Line53
        '
        Me.Line53.Height = 0.2666667!
        Me.Line53.Left = 7.26666!
        Me.Line53.LineWeight = 1!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 0.8!
        Me.Line53.Width = 0!
        Me.Line53.X1 = 7.26666!
        Me.Line53.X2 = 7.26666!
        Me.Line53.Y1 = 0.8!
        Me.Line53.Y2 = 1.066667!
        '
        'Line54
        '
        Me.Line54.Height = 0!
        Me.Line54.Left = 0.06666667!
        Me.Line54.LineWeight = 1!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 1.066667!
        Me.Line54.Width = 7.2!
        Me.Line54.X1 = 0.06666667!
        Me.Line54.X2 = 7.266667!
        Me.Line54.Y1 = 1.066667!
        Me.Line54.Y2 = 1.066667!
        '
        'Line55
        '
        Me.Line55.Height = 0.2666667!
        Me.Line55.Left = 0.06666667!
        Me.Line55.LineWeight = 1!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 1.066667!
        Me.Line55.Width = 0!
        Me.Line55.X1 = 0.06666667!
        Me.Line55.X2 = 0.06666667!
        Me.Line55.Y1 = 1.066667!
        Me.Line55.Y2 = 1.333333!
        '
        'Line56
        '
        Me.Line56.Height = 0.2666667!
        Me.Line56.Left = 0.5333334!
        Me.Line56.LineWeight = 1!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 1.066667!
        Me.Line56.Width = 0!
        Me.Line56.X1 = 0.5333334!
        Me.Line56.X2 = 0.5333334!
        Me.Line56.Y1 = 1.066667!
        Me.Line56.Y2 = 1.333333!
        '
        'Line57
        '
        Me.Line57.Height = 0.2666672!
        Me.Line57.Left = 1.333333!
        Me.Line57.LineWeight = 1!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 1.066667!
        Me.Line57.Width = 0!
        Me.Line57.X1 = 1.333333!
        Me.Line57.X2 = 1.333333!
        Me.Line57.Y1 = 1.066667!
        Me.Line57.Y2 = 1.333334!
        '
        'Line58
        '
        Me.Line58.Height = 0.2666672!
        Me.Line58.Left = 1.995834!
        Me.Line58.LineWeight = 1!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 1.066667!
        Me.Line58.Width = 0!
        Me.Line58.X1 = 1.995834!
        Me.Line58.X2 = 1.995834!
        Me.Line58.Y1 = 1.066667!
        Me.Line58.Y2 = 1.333334!
        '
        'Line59
        '
        Me.Line59.Height = 0.2666672!
        Me.Line59.Left = 2.6!
        Me.Line59.LineWeight = 1!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 1.066667!
        Me.Line59.Width = 0!
        Me.Line59.X1 = 2.6!
        Me.Line59.X2 = 2.6!
        Me.Line59.Y1 = 1.066667!
        Me.Line59.Y2 = 1.333334!
        '
        'Line60
        '
        Me.Line60.Height = 0.2666672!
        Me.Line60.Left = 4.133333!
        Me.Line60.LineWeight = 1!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 1.066667!
        Me.Line60.Width = 0!
        Me.Line60.X1 = 4.133333!
        Me.Line60.X2 = 4.133333!
        Me.Line60.Y1 = 1.066667!
        Me.Line60.Y2 = 1.333334!
        '
        'Line61
        '
        Me.Line61.Height = 0.2666672!
        Me.Line61.Left = 5.199998!
        Me.Line61.LineWeight = 1!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 1.066667!
        Me.Line61.Width = 0!
        Me.Line61.X1 = 5.199998!
        Me.Line61.X2 = 5.199998!
        Me.Line61.Y1 = 1.066667!
        Me.Line61.Y2 = 1.333334!
        '
        'Line62
        '
        Me.Line62.Height = 0.2666672!
        Me.Line62.Left = 5.733331!
        Me.Line62.LineWeight = 1!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 1.066667!
        Me.Line62.Width = 0!
        Me.Line62.X1 = 5.733331!
        Me.Line62.X2 = 5.733331!
        Me.Line62.Y1 = 1.066667!
        Me.Line62.Y2 = 1.333334!
        '
        'Line63
        '
        Me.Line63.Height = 0.2666672!
        Me.Line63.Left = 6.266663!
        Me.Line63.LineWeight = 1!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 1.066667!
        Me.Line63.Width = 0!
        Me.Line63.X1 = 6.266663!
        Me.Line63.X2 = 6.266663!
        Me.Line63.Y1 = 1.066667!
        Me.Line63.Y2 = 1.333334!
        '
        'Line64
        '
        Me.Line64.Height = 0.2666672!
        Me.Line64.Left = 7.26666!
        Me.Line64.LineWeight = 1!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 1.066667!
        Me.Line64.Width = 0!
        Me.Line64.X1 = 7.26666!
        Me.Line64.X2 = 7.26666!
        Me.Line64.Y1 = 1.066667!
        Me.Line64.Y2 = 1.333334!
        '
        'Line65
        '
        Me.Line65.Height = 0!
        Me.Line65.Left = 0.06666667!
        Me.Line65.LineWeight = 1!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 1.333333!
        Me.Line65.Width = 7.2!
        Me.Line65.X1 = 0.06666667!
        Me.Line65.X2 = 7.266667!
        Me.Line65.Y1 = 1.333333!
        Me.Line65.Y2 = 1.333333!
        '
        'Line66
        '
        Me.Line66.Height = 0.2666672!
        Me.Line66.Left = 0.06666667!
        Me.Line66.LineWeight = 1!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 1.333333!
        Me.Line66.Width = 0!
        Me.Line66.X1 = 0.06666667!
        Me.Line66.X2 = 0.06666667!
        Me.Line66.Y1 = 1.333333!
        Me.Line66.Y2 = 1.600001!
        '
        'Line67
        '
        Me.Line67.Height = 0.2666672!
        Me.Line67.Left = 0.5333334!
        Me.Line67.LineWeight = 1!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 1.333333!
        Me.Line67.Width = 0!
        Me.Line67.X1 = 0.5333334!
        Me.Line67.X2 = 0.5333334!
        Me.Line67.Y1 = 1.333333!
        Me.Line67.Y2 = 1.600001!
        '
        'Line68
        '
        Me.Line68.Height = 0.2666672!
        Me.Line68.Left = 1.333333!
        Me.Line68.LineWeight = 1!
        Me.Line68.Name = "Line68"
        Me.Line68.Top = 1.333333!
        Me.Line68.Width = 0!
        Me.Line68.X1 = 1.333333!
        Me.Line68.X2 = 1.333333!
        Me.Line68.Y1 = 1.333333!
        Me.Line68.Y2 = 1.600001!
        '
        'Line69
        '
        Me.Line69.Height = 0.2666672!
        Me.Line69.Left = 1.995834!
        Me.Line69.LineWeight = 1!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 1.333333!
        Me.Line69.Width = 0!
        Me.Line69.X1 = 1.995834!
        Me.Line69.X2 = 1.995834!
        Me.Line69.Y1 = 1.333333!
        Me.Line69.Y2 = 1.600001!
        '
        'Line70
        '
        Me.Line70.Height = 0.2666672!
        Me.Line70.Left = 2.6!
        Me.Line70.LineWeight = 1!
        Me.Line70.Name = "Line70"
        Me.Line70.Top = 1.333333!
        Me.Line70.Width = 0!
        Me.Line70.X1 = 2.6!
        Me.Line70.X2 = 2.6!
        Me.Line70.Y1 = 1.333333!
        Me.Line70.Y2 = 1.600001!
        '
        'Line71
        '
        Me.Line71.Height = 0.2666667!
        Me.Line71.Left = 4.133333!
        Me.Line71.LineWeight = 1!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 1.333334!
        Me.Line71.Width = 0!
        Me.Line71.X1 = 4.133333!
        Me.Line71.X2 = 4.133333!
        Me.Line71.Y1 = 1.333334!
        Me.Line71.Y2 = 1.600001!
        '
        'Line72
        '
        Me.Line72.Height = 0.2666667!
        Me.Line72.Left = 5.199998!
        Me.Line72.LineWeight = 1!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 1.333334!
        Me.Line72.Width = 0!
        Me.Line72.X1 = 5.199998!
        Me.Line72.X2 = 5.199998!
        Me.Line72.Y1 = 1.333334!
        Me.Line72.Y2 = 1.600001!
        '
        'Line73
        '
        Me.Line73.Height = 0.2666672!
        Me.Line73.Left = 5.733331!
        Me.Line73.LineWeight = 1!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 1.333333!
        Me.Line73.Width = 0!
        Me.Line73.X1 = 5.733331!
        Me.Line73.X2 = 5.733331!
        Me.Line73.Y1 = 1.333333!
        Me.Line73.Y2 = 1.600001!
        '
        'Line74
        '
        Me.Line74.Height = 0.2666667!
        Me.Line74.Left = 6.266663!
        Me.Line74.LineWeight = 1!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 1.333334!
        Me.Line74.Width = 0!
        Me.Line74.X1 = 6.266663!
        Me.Line74.X2 = 6.266663!
        Me.Line74.Y1 = 1.333334!
        Me.Line74.Y2 = 1.600001!
        '
        'Line75
        '
        Me.Line75.Height = 0.2666672!
        Me.Line75.Left = 7.26666!
        Me.Line75.LineWeight = 1!
        Me.Line75.Name = "Line75"
        Me.Line75.Top = 1.333333!
        Me.Line75.Width = 0!
        Me.Line75.X1 = 7.26666!
        Me.Line75.X2 = 7.26666!
        Me.Line75.Y1 = 1.333333!
        Me.Line75.Y2 = 1.600001!
        '
        'Line76
        '
        Me.Line76.Height = 0!
        Me.Line76.Left = 0.06666667!
        Me.Line76.LineWeight = 1!
        Me.Line76.Name = "Line76"
        Me.Line76.Top = 1.600001!
        Me.Line76.Width = 7.2!
        Me.Line76.X1 = 0.06666667!
        Me.Line76.X2 = 7.266667!
        Me.Line76.Y1 = 1.600001!
        Me.Line76.Y2 = 1.600001!
        '
        'Line77
        '
        Me.Line77.Height = 0.2666668!
        Me.Line77.Left = 0.06666667!
        Me.Line77.LineWeight = 1!
        Me.Line77.Name = "Line77"
        Me.Line77.Top = 1.600001!
        Me.Line77.Width = 0!
        Me.Line77.X1 = 0.06666667!
        Me.Line77.X2 = 0.06666667!
        Me.Line77.Y1 = 1.600001!
        Me.Line77.Y2 = 1.866667!
        '
        'Line78
        '
        Me.Line78.Height = 0.2666668!
        Me.Line78.Left = 0.5333334!
        Me.Line78.LineWeight = 1!
        Me.Line78.Name = "Line78"
        Me.Line78.Top = 1.600001!
        Me.Line78.Width = 0!
        Me.Line78.X1 = 0.5333334!
        Me.Line78.X2 = 0.5333334!
        Me.Line78.Y1 = 1.600001!
        Me.Line78.Y2 = 1.866667!
        '
        'Line79
        '
        Me.Line79.Height = 0.2666668!
        Me.Line79.Left = 1.333333!
        Me.Line79.LineWeight = 1!
        Me.Line79.Name = "Line79"
        Me.Line79.Top = 1.600001!
        Me.Line79.Width = 0!
        Me.Line79.X1 = 1.333333!
        Me.Line79.X2 = 1.333333!
        Me.Line79.Y1 = 1.600001!
        Me.Line79.Y2 = 1.866667!
        '
        'Line80
        '
        Me.Line80.Height = 0.2666668!
        Me.Line80.Left = 1.995834!
        Me.Line80.LineWeight = 1!
        Me.Line80.Name = "Line80"
        Me.Line80.Top = 1.600001!
        Me.Line80.Width = 0!
        Me.Line80.X1 = 1.995834!
        Me.Line80.X2 = 1.995834!
        Me.Line80.Y1 = 1.600001!
        Me.Line80.Y2 = 1.866667!
        '
        'Line81
        '
        Me.Line81.Height = 0.2666668!
        Me.Line81.Left = 2.6!
        Me.Line81.LineWeight = 1!
        Me.Line81.Name = "Line81"
        Me.Line81.Top = 1.600001!
        Me.Line81.Width = 0!
        Me.Line81.X1 = 2.6!
        Me.Line81.X2 = 2.6!
        Me.Line81.Y1 = 1.600001!
        Me.Line81.Y2 = 1.866667!
        '
        'Line82
        '
        Me.Line82.Height = 0.2666668!
        Me.Line82.Left = 4.133333!
        Me.Line82.LineWeight = 1!
        Me.Line82.Name = "Line82"
        Me.Line82.Top = 1.600001!
        Me.Line82.Width = 0!
        Me.Line82.X1 = 4.133333!
        Me.Line82.X2 = 4.133333!
        Me.Line82.Y1 = 1.600001!
        Me.Line82.Y2 = 1.866667!
        '
        'Line83
        '
        Me.Line83.Height = 0.2666668!
        Me.Line83.Left = 5.199998!
        Me.Line83.LineWeight = 1!
        Me.Line83.Name = "Line83"
        Me.Line83.Top = 1.600001!
        Me.Line83.Width = 0!
        Me.Line83.X1 = 5.199998!
        Me.Line83.X2 = 5.199998!
        Me.Line83.Y1 = 1.600001!
        Me.Line83.Y2 = 1.866667!
        '
        'Line84
        '
        Me.Line84.Height = 0.2666668!
        Me.Line84.Left = 5.733331!
        Me.Line84.LineWeight = 1!
        Me.Line84.Name = "Line84"
        Me.Line84.Top = 1.600001!
        Me.Line84.Width = 0!
        Me.Line84.X1 = 5.733331!
        Me.Line84.X2 = 5.733331!
        Me.Line84.Y1 = 1.600001!
        Me.Line84.Y2 = 1.866667!
        '
        'Line85
        '
        Me.Line85.Height = 0.2666668!
        Me.Line85.Left = 6.266663!
        Me.Line85.LineWeight = 1!
        Me.Line85.Name = "Line85"
        Me.Line85.Top = 1.600001!
        Me.Line85.Width = 0!
        Me.Line85.X1 = 6.266663!
        Me.Line85.X2 = 6.266663!
        Me.Line85.Y1 = 1.600001!
        Me.Line85.Y2 = 1.866667!
        '
        'Line86
        '
        Me.Line86.Height = 0.2666668!
        Me.Line86.Left = 7.26666!
        Me.Line86.LineWeight = 1!
        Me.Line86.Name = "Line86"
        Me.Line86.Top = 1.600001!
        Me.Line86.Width = 0!
        Me.Line86.X1 = 7.26666!
        Me.Line86.X2 = 7.26666!
        Me.Line86.Y1 = 1.600001!
        Me.Line86.Y2 = 1.866667!
        '
        'Line87
        '
        Me.Line87.Height = 0!
        Me.Line87.Left = 0.06666667!
        Me.Line87.LineWeight = 1!
        Me.Line87.Name = "Line87"
        Me.Line87.Top = 1.866667!
        Me.Line87.Width = 7.2!
        Me.Line87.X1 = 0.06666667!
        Me.Line87.X2 = 7.266667!
        Me.Line87.Y1 = 1.866667!
        Me.Line87.Y2 = 1.866667!
        '
        'Line88
        '
        Me.Line88.Height = 0.2666665!
        Me.Line88.Left = 0.06666667!
        Me.Line88.LineWeight = 1!
        Me.Line88.Name = "Line88"
        Me.Line88.Top = 1.866667!
        Me.Line88.Width = 0!
        Me.Line88.X1 = 0.06666667!
        Me.Line88.X2 = 0.06666667!
        Me.Line88.Y1 = 1.866667!
        Me.Line88.Y2 = 2.133334!
        '
        'Line89
        '
        Me.Line89.Height = 0.2666665!
        Me.Line89.Left = 0.5333334!
        Me.Line89.LineWeight = 1!
        Me.Line89.Name = "Line89"
        Me.Line89.Top = 1.866667!
        Me.Line89.Width = 0!
        Me.Line89.X1 = 0.5333334!
        Me.Line89.X2 = 0.5333334!
        Me.Line89.Y1 = 1.866667!
        Me.Line89.Y2 = 2.133334!
        '
        'Line90
        '
        Me.Line90.Height = 0.2666665!
        Me.Line90.Left = 1.333333!
        Me.Line90.LineWeight = 1!
        Me.Line90.Name = "Line90"
        Me.Line90.Top = 1.866667!
        Me.Line90.Width = 0!
        Me.Line90.X1 = 1.333333!
        Me.Line90.X2 = 1.333333!
        Me.Line90.Y1 = 1.866667!
        Me.Line90.Y2 = 2.133334!
        '
        'Line91
        '
        Me.Line91.Height = 0.2666665!
        Me.Line91.Left = 1.995834!
        Me.Line91.LineWeight = 1!
        Me.Line91.Name = "Line91"
        Me.Line91.Top = 1.866667!
        Me.Line91.Width = 0!
        Me.Line91.X1 = 1.995834!
        Me.Line91.X2 = 1.995834!
        Me.Line91.Y1 = 1.866667!
        Me.Line91.Y2 = 2.133334!
        '
        'Line92
        '
        Me.Line92.Height = 0.2666665!
        Me.Line92.Left = 2.6!
        Me.Line92.LineWeight = 1!
        Me.Line92.Name = "Line92"
        Me.Line92.Top = 1.866667!
        Me.Line92.Width = 0!
        Me.Line92.X1 = 2.6!
        Me.Line92.X2 = 2.6!
        Me.Line92.Y1 = 1.866667!
        Me.Line92.Y2 = 2.133334!
        '
        'Line93
        '
        Me.Line93.Height = 0.2666665!
        Me.Line93.Left = 4.133333!
        Me.Line93.LineWeight = 1!
        Me.Line93.Name = "Line93"
        Me.Line93.Top = 1.866667!
        Me.Line93.Width = 0!
        Me.Line93.X1 = 4.133333!
        Me.Line93.X2 = 4.133333!
        Me.Line93.Y1 = 1.866667!
        Me.Line93.Y2 = 2.133334!
        '
        'Line94
        '
        Me.Line94.Height = 0.2666665!
        Me.Line94.Left = 5.199998!
        Me.Line94.LineWeight = 1!
        Me.Line94.Name = "Line94"
        Me.Line94.Top = 1.866667!
        Me.Line94.Width = 0!
        Me.Line94.X1 = 5.199998!
        Me.Line94.X2 = 5.199998!
        Me.Line94.Y1 = 1.866667!
        Me.Line94.Y2 = 2.133334!
        '
        'Line95
        '
        Me.Line95.Height = 0.2666665!
        Me.Line95.Left = 5.733331!
        Me.Line95.LineWeight = 1!
        Me.Line95.Name = "Line95"
        Me.Line95.Top = 1.866667!
        Me.Line95.Width = 0!
        Me.Line95.X1 = 5.733331!
        Me.Line95.X2 = 5.733331!
        Me.Line95.Y1 = 1.866667!
        Me.Line95.Y2 = 2.133334!
        '
        'Line96
        '
        Me.Line96.Height = 0.2666665!
        Me.Line96.Left = 6.266663!
        Me.Line96.LineWeight = 1!
        Me.Line96.Name = "Line96"
        Me.Line96.Top = 1.866667!
        Me.Line96.Width = 0!
        Me.Line96.X1 = 6.266663!
        Me.Line96.X2 = 6.266663!
        Me.Line96.Y1 = 1.866667!
        Me.Line96.Y2 = 2.133334!
        '
        'Line97
        '
        Me.Line97.Height = 0.2666665!
        Me.Line97.Left = 7.26666!
        Me.Line97.LineWeight = 1!
        Me.Line97.Name = "Line97"
        Me.Line97.Top = 1.866667!
        Me.Line97.Width = 0!
        Me.Line97.X1 = 7.26666!
        Me.Line97.X2 = 7.26666!
        Me.Line97.Y1 = 1.866667!
        Me.Line97.Y2 = 2.133334!
        '
        'Line98
        '
        Me.Line98.Height = 0!
        Me.Line98.Left = 0.06666667!
        Me.Line98.LineWeight = 1!
        Me.Line98.Name = "Line98"
        Me.Line98.Top = 2.133334!
        Me.Line98.Width = 7.2!
        Me.Line98.X1 = 0.06666667!
        Me.Line98.X2 = 7.266667!
        Me.Line98.Y1 = 2.133334!
        Me.Line98.Y2 = 2.133334!
        '
        'Line99
        '
        Me.Line99.Height = 0.2666662!
        Me.Line99.Left = 0.06666667!
        Me.Line99.LineWeight = 1!
        Me.Line99.Name = "Line99"
        Me.Line99.Top = 2.133334!
        Me.Line99.Width = 0!
        Me.Line99.X1 = 0.06666667!
        Me.Line99.X2 = 0.06666667!
        Me.Line99.Y1 = 2.133334!
        Me.Line99.Y2 = 2.4!
        '
        'Line100
        '
        Me.Line100.Height = 0.2666662!
        Me.Line100.Left = 0.5333334!
        Me.Line100.LineWeight = 1!
        Me.Line100.Name = "Line100"
        Me.Line100.Top = 2.133334!
        Me.Line100.Width = 0!
        Me.Line100.X1 = 0.5333334!
        Me.Line100.X2 = 0.5333334!
        Me.Line100.Y1 = 2.133334!
        Me.Line100.Y2 = 2.4!
        '
        'Line101
        '
        Me.Line101.Height = 0.2666667!
        Me.Line101.Left = 1.333333!
        Me.Line101.LineWeight = 1!
        Me.Line101.Name = "Line101"
        Me.Line101.Top = 2.133334!
        Me.Line101.Width = 0!
        Me.Line101.X1 = 1.333333!
        Me.Line101.X2 = 1.333333!
        Me.Line101.Y1 = 2.133334!
        Me.Line101.Y2 = 2.400001!
        '
        'Line102
        '
        Me.Line102.Height = 0.2666667!
        Me.Line102.Left = 1.995834!
        Me.Line102.LineWeight = 1!
        Me.Line102.Name = "Line102"
        Me.Line102.Top = 2.133334!
        Me.Line102.Width = 0!
        Me.Line102.X1 = 1.995834!
        Me.Line102.X2 = 1.995834!
        Me.Line102.Y1 = 2.133334!
        Me.Line102.Y2 = 2.400001!
        '
        'Line103
        '
        Me.Line103.Height = 0.2666667!
        Me.Line103.Left = 2.6!
        Me.Line103.LineWeight = 1!
        Me.Line103.Name = "Line103"
        Me.Line103.Top = 2.133334!
        Me.Line103.Width = 0!
        Me.Line103.X1 = 2.6!
        Me.Line103.X2 = 2.6!
        Me.Line103.Y1 = 2.133334!
        Me.Line103.Y2 = 2.400001!
        '
        'Line104
        '
        Me.Line104.Height = 0.2666667!
        Me.Line104.Left = 4.133333!
        Me.Line104.LineWeight = 1!
        Me.Line104.Name = "Line104"
        Me.Line104.Top = 2.133334!
        Me.Line104.Width = 0!
        Me.Line104.X1 = 4.133333!
        Me.Line104.X2 = 4.133333!
        Me.Line104.Y1 = 2.133334!
        Me.Line104.Y2 = 2.400001!
        '
        'Line105
        '
        Me.Line105.Height = 0.2666667!
        Me.Line105.Left = 5.199998!
        Me.Line105.LineWeight = 1!
        Me.Line105.Name = "Line105"
        Me.Line105.Top = 2.133334!
        Me.Line105.Width = 0!
        Me.Line105.X1 = 5.199998!
        Me.Line105.X2 = 5.199998!
        Me.Line105.Y1 = 2.133334!
        Me.Line105.Y2 = 2.400001!
        '
        'Line106
        '
        Me.Line106.Height = 0.2666667!
        Me.Line106.Left = 5.733331!
        Me.Line106.LineWeight = 1!
        Me.Line106.Name = "Line106"
        Me.Line106.Top = 2.133334!
        Me.Line106.Width = 0!
        Me.Line106.X1 = 5.733331!
        Me.Line106.X2 = 5.733331!
        Me.Line106.Y1 = 2.133334!
        Me.Line106.Y2 = 2.400001!
        '
        'Line107
        '
        Me.Line107.Height = 0.2666667!
        Me.Line107.Left = 6.266663!
        Me.Line107.LineWeight = 1!
        Me.Line107.Name = "Line107"
        Me.Line107.Top = 2.133334!
        Me.Line107.Width = 0!
        Me.Line107.X1 = 6.266663!
        Me.Line107.X2 = 6.266663!
        Me.Line107.Y1 = 2.133334!
        Me.Line107.Y2 = 2.400001!
        '
        'Line108
        '
        Me.Line108.Height = 0.2666667!
        Me.Line108.Left = 7.26666!
        Me.Line108.LineWeight = 1!
        Me.Line108.Name = "Line108"
        Me.Line108.Top = 2.133334!
        Me.Line108.Width = 0!
        Me.Line108.X1 = 7.26666!
        Me.Line108.X2 = 7.26666!
        Me.Line108.Y1 = 2.133334!
        Me.Line108.Y2 = 2.400001!
        '
        'Line109
        '
        Me.Line109.Height = 0!
        Me.Line109.Left = 0.06666667!
        Me.Line109.LineWeight = 1!
        Me.Line109.Name = "Line109"
        Me.Line109.Top = 2.4!
        Me.Line109.Width = 7.2!
        Me.Line109.X1 = 0.06666667!
        Me.Line109.X2 = 7.266667!
        Me.Line109.Y1 = 2.4!
        Me.Line109.Y2 = 2.4!
        '
        'Line110
        '
        Me.Line110.Height = 0.2666667!
        Me.Line110.Left = 0.06666667!
        Me.Line110.LineWeight = 1!
        Me.Line110.Name = "Line110"
        Me.Line110.Top = 2.4!
        Me.Line110.Width = 0!
        Me.Line110.X1 = 0.06666667!
        Me.Line110.X2 = 0.06666667!
        Me.Line110.Y1 = 2.4!
        Me.Line110.Y2 = 2.666667!
        '
        'Line111
        '
        Me.Line111.Height = 0.2666667!
        Me.Line111.Left = 0.5333334!
        Me.Line111.LineWeight = 1!
        Me.Line111.Name = "Line111"
        Me.Line111.Top = 2.4!
        Me.Line111.Width = 0!
        Me.Line111.X1 = 0.5333334!
        Me.Line111.X2 = 0.5333334!
        Me.Line111.Y1 = 2.4!
        Me.Line111.Y2 = 2.666667!
        '
        'Line112
        '
        Me.Line112.Height = 0.2666667!
        Me.Line112.Left = 1.333333!
        Me.Line112.LineWeight = 1!
        Me.Line112.Name = "Line112"
        Me.Line112.Top = 2.4!
        Me.Line112.Width = 0!
        Me.Line112.X1 = 1.333333!
        Me.Line112.X2 = 1.333333!
        Me.Line112.Y1 = 2.4!
        Me.Line112.Y2 = 2.666667!
        '
        'Line113
        '
        Me.Line113.Height = 0.2666667!
        Me.Line113.Left = 1.995834!
        Me.Line113.LineWeight = 1!
        Me.Line113.Name = "Line113"
        Me.Line113.Top = 2.4!
        Me.Line113.Width = 0!
        Me.Line113.X1 = 1.995834!
        Me.Line113.X2 = 1.995834!
        Me.Line113.Y1 = 2.4!
        Me.Line113.Y2 = 2.666667!
        '
        'Line114
        '
        Me.Line114.Height = 0.2666667!
        Me.Line114.Left = 2.6!
        Me.Line114.LineWeight = 1!
        Me.Line114.Name = "Line114"
        Me.Line114.Top = 2.4!
        Me.Line114.Width = 0!
        Me.Line114.X1 = 2.6!
        Me.Line114.X2 = 2.6!
        Me.Line114.Y1 = 2.4!
        Me.Line114.Y2 = 2.666667!
        '
        'Line115
        '
        Me.Line115.Height = 0.2666662!
        Me.Line115.Left = 4.133333!
        Me.Line115.LineWeight = 1!
        Me.Line115.Name = "Line115"
        Me.Line115.Top = 2.400001!
        Me.Line115.Width = 0!
        Me.Line115.X1 = 4.133333!
        Me.Line115.X2 = 4.133333!
        Me.Line115.Y1 = 2.400001!
        Me.Line115.Y2 = 2.666667!
        '
        'Line116
        '
        Me.Line116.Height = 0.2666662!
        Me.Line116.Left = 5.199998!
        Me.Line116.LineWeight = 1!
        Me.Line116.Name = "Line116"
        Me.Line116.Top = 2.400001!
        Me.Line116.Width = 0!
        Me.Line116.X1 = 5.199998!
        Me.Line116.X2 = 5.199998!
        Me.Line116.Y1 = 2.400001!
        Me.Line116.Y2 = 2.666667!
        '
        'Line117
        '
        Me.Line117.Height = 0.2666667!
        Me.Line117.Left = 5.733331!
        Me.Line117.LineWeight = 1!
        Me.Line117.Name = "Line117"
        Me.Line117.Top = 2.4!
        Me.Line117.Width = 0!
        Me.Line117.X1 = 5.733331!
        Me.Line117.X2 = 5.733331!
        Me.Line117.Y1 = 2.4!
        Me.Line117.Y2 = 2.666667!
        '
        'Line118
        '
        Me.Line118.Height = 0.2666662!
        Me.Line118.Left = 6.266663!
        Me.Line118.LineWeight = 1!
        Me.Line118.Name = "Line118"
        Me.Line118.Top = 2.400001!
        Me.Line118.Width = 0!
        Me.Line118.X1 = 6.266663!
        Me.Line118.X2 = 6.266663!
        Me.Line118.Y1 = 2.400001!
        Me.Line118.Y2 = 2.666667!
        '
        'Line119
        '
        Me.Line119.Height = 0.2666667!
        Me.Line119.Left = 7.26666!
        Me.Line119.LineWeight = 1!
        Me.Line119.Name = "Line119"
        Me.Line119.Top = 2.4!
        Me.Line119.Width = 0!
        Me.Line119.X1 = 7.26666!
        Me.Line119.X2 = 7.26666!
        Me.Line119.Y1 = 2.4!
        Me.Line119.Y2 = 2.666667!
        '
        'Line120
        '
        Me.Line120.Height = 0!
        Me.Line120.Left = 0.06666667!
        Me.Line120.LineWeight = 1!
        Me.Line120.Name = "Line120"
        Me.Line120.Top = 2.666667!
        Me.Line120.Width = 7.2!
        Me.Line120.X1 = 0.06666667!
        Me.Line120.X2 = 7.266667!
        Me.Line120.Y1 = 2.666667!
        Me.Line120.Y2 = 2.666667!
        '
        'Line121
        '
        Me.Line121.Height = 0.2666667!
        Me.Line121.Left = 0.06666667!
        Me.Line121.LineWeight = 1!
        Me.Line121.Name = "Line121"
        Me.Line121.Top = 2.666667!
        Me.Line121.Width = 0!
        Me.Line121.X1 = 0.06666667!
        Me.Line121.X2 = 0.06666667!
        Me.Line121.Y1 = 2.666667!
        Me.Line121.Y2 = 2.933333!
        '
        'Line122
        '
        Me.Line122.Height = 0.2666667!
        Me.Line122.Left = 0.5333334!
        Me.Line122.LineWeight = 1!
        Me.Line122.Name = "Line122"
        Me.Line122.Top = 2.666667!
        Me.Line122.Width = 0!
        Me.Line122.X1 = 0.5333334!
        Me.Line122.X2 = 0.5333334!
        Me.Line122.Y1 = 2.666667!
        Me.Line122.Y2 = 2.933333!
        '
        'Line123
        '
        Me.Line123.Height = 0.2666667!
        Me.Line123.Left = 1.333333!
        Me.Line123.LineWeight = 1!
        Me.Line123.Name = "Line123"
        Me.Line123.Top = 2.666667!
        Me.Line123.Width = 0!
        Me.Line123.X1 = 1.333333!
        Me.Line123.X2 = 1.333333!
        Me.Line123.Y1 = 2.666667!
        Me.Line123.Y2 = 2.933333!
        '
        'Line124
        '
        Me.Line124.Height = 0.2666667!
        Me.Line124.Left = 1.995834!
        Me.Line124.LineWeight = 1!
        Me.Line124.Name = "Line124"
        Me.Line124.Top = 2.666667!
        Me.Line124.Width = 0!
        Me.Line124.X1 = 1.995834!
        Me.Line124.X2 = 1.995834!
        Me.Line124.Y1 = 2.666667!
        Me.Line124.Y2 = 2.933333!
        '
        'Line125
        '
        Me.Line125.Height = 0.2666667!
        Me.Line125.Left = 2.6!
        Me.Line125.LineWeight = 1!
        Me.Line125.Name = "Line125"
        Me.Line125.Top = 2.666667!
        Me.Line125.Width = 0!
        Me.Line125.X1 = 2.6!
        Me.Line125.X2 = 2.6!
        Me.Line125.Y1 = 2.666667!
        Me.Line125.Y2 = 2.933333!
        '
        'Line126
        '
        Me.Line126.Height = 0.2666667!
        Me.Line126.Left = 4.133333!
        Me.Line126.LineWeight = 1!
        Me.Line126.Name = "Line126"
        Me.Line126.Top = 2.666667!
        Me.Line126.Width = 0!
        Me.Line126.X1 = 4.133333!
        Me.Line126.X2 = 4.133333!
        Me.Line126.Y1 = 2.666667!
        Me.Line126.Y2 = 2.933333!
        '
        'Line127
        '
        Me.Line127.Height = 0.2666667!
        Me.Line127.Left = 5.199998!
        Me.Line127.LineWeight = 1!
        Me.Line127.Name = "Line127"
        Me.Line127.Top = 2.666667!
        Me.Line127.Width = 0!
        Me.Line127.X1 = 5.199998!
        Me.Line127.X2 = 5.199998!
        Me.Line127.Y1 = 2.666667!
        Me.Line127.Y2 = 2.933334!
        '
        'Line128
        '
        Me.Line128.Height = 0.2666674!
        Me.Line128.Left = 5.733331!
        Me.Line128.LineWeight = 1!
        Me.Line128.Name = "Line128"
        Me.Line128.Top = 2.666667!
        Me.Line128.Width = 0!
        Me.Line128.X1 = 5.733331!
        Me.Line128.X2 = 5.733331!
        Me.Line128.Y1 = 2.666667!
        Me.Line128.Y2 = 2.933334!
        '
        'Line129
        '
        Me.Line129.Height = 0.2666674!
        Me.Line129.Left = 6.266663!
        Me.Line129.LineWeight = 1!
        Me.Line129.Name = "Line129"
        Me.Line129.Top = 2.666667!
        Me.Line129.Width = 0!
        Me.Line129.X1 = 6.266663!
        Me.Line129.X2 = 6.266663!
        Me.Line129.Y1 = 2.666667!
        Me.Line129.Y2 = 2.933334!
        '
        'Line130
        '
        Me.Line130.Height = 0.2666674!
        Me.Line130.Left = 7.26666!
        Me.Line130.LineWeight = 1!
        Me.Line130.Name = "Line130"
        Me.Line130.Top = 2.666667!
        Me.Line130.Width = 0!
        Me.Line130.X1 = 7.26666!
        Me.Line130.X2 = 7.26666!
        Me.Line130.Y1 = 2.666667!
        Me.Line130.Y2 = 2.933334!
        '
        'Line131
        '
        Me.Line131.Height = 0!
        Me.Line131.Left = 0.06666667!
        Me.Line131.LineWeight = 1!
        Me.Line131.Name = "Line131"
        Me.Line131.Top = 2.933333!
        Me.Line131.Width = 7.2!
        Me.Line131.X1 = 0.06666667!
        Me.Line131.X2 = 7.266667!
        Me.Line131.Y1 = 2.933333!
        Me.Line131.Y2 = 2.933333!
        '
        'Line132
        '
        Me.Line132.Height = 0.2666667!
        Me.Line132.Left = 0.06666667!
        Me.Line132.LineWeight = 1!
        Me.Line132.Name = "Line132"
        Me.Line132.Top = 2.933333!
        Me.Line132.Width = 0!
        Me.Line132.X1 = 0.06666667!
        Me.Line132.X2 = 0.06666667!
        Me.Line132.Y1 = 2.933333!
        Me.Line132.Y2 = 3.2!
        '
        'Line133
        '
        Me.Line133.Height = 0.2666667!
        Me.Line133.Left = 0.5333334!
        Me.Line133.LineWeight = 1!
        Me.Line133.Name = "Line133"
        Me.Line133.Top = 2.933333!
        Me.Line133.Width = 0!
        Me.Line133.X1 = 0.5333334!
        Me.Line133.X2 = 0.5333334!
        Me.Line133.Y1 = 2.933333!
        Me.Line133.Y2 = 3.2!
        '
        'Line134
        '
        Me.Line134.Height = 0.2666667!
        Me.Line134.Left = 1.333333!
        Me.Line134.LineWeight = 1!
        Me.Line134.Name = "Line134"
        Me.Line134.Top = 2.933333!
        Me.Line134.Width = 0!
        Me.Line134.X1 = 1.333333!
        Me.Line134.X2 = 1.333333!
        Me.Line134.Y1 = 2.933333!
        Me.Line134.Y2 = 3.2!
        '
        'Line135
        '
        Me.Line135.Height = 0.2666667!
        Me.Line135.Left = 1.995834!
        Me.Line135.LineWeight = 1!
        Me.Line135.Name = "Line135"
        Me.Line135.Top = 2.933333!
        Me.Line135.Width = 0!
        Me.Line135.X1 = 1.995834!
        Me.Line135.X2 = 1.995834!
        Me.Line135.Y1 = 2.933333!
        Me.Line135.Y2 = 3.2!
        '
        'Line136
        '
        Me.Line136.Height = 0.2666667!
        Me.Line136.Left = 2.6!
        Me.Line136.LineWeight = 1!
        Me.Line136.Name = "Line136"
        Me.Line136.Top = 2.933333!
        Me.Line136.Width = 0!
        Me.Line136.X1 = 2.6!
        Me.Line136.X2 = 2.6!
        Me.Line136.Y1 = 2.933333!
        Me.Line136.Y2 = 3.2!
        '
        'Line137
        '
        Me.Line137.Height = 0.2666667!
        Me.Line137.Left = 4.133333!
        Me.Line137.LineWeight = 1!
        Me.Line137.Name = "Line137"
        Me.Line137.Top = 2.933333!
        Me.Line137.Width = 0!
        Me.Line137.X1 = 4.133333!
        Me.Line137.X2 = 4.133333!
        Me.Line137.Y1 = 2.933333!
        Me.Line137.Y2 = 3.2!
        '
        'Line138
        '
        Me.Line138.Height = 0.2666667!
        Me.Line138.Left = 5.199998!
        Me.Line138.LineWeight = 1!
        Me.Line138.Name = "Line138"
        Me.Line138.Top = 2.933334!
        Me.Line138.Width = 0!
        Me.Line138.X1 = 5.199998!
        Me.Line138.X2 = 5.199998!
        Me.Line138.Y1 = 2.933334!
        Me.Line138.Y2 = 3.200001!
        '
        'Line139
        '
        Me.Line139.Height = 0.2666674!
        Me.Line139.Left = 5.733331!
        Me.Line139.LineWeight = 1!
        Me.Line139.Name = "Line139"
        Me.Line139.Top = 2.933333!
        Me.Line139.Width = 0!
        Me.Line139.X1 = 5.733331!
        Me.Line139.X2 = 5.733331!
        Me.Line139.Y1 = 2.933333!
        Me.Line139.Y2 = 3.200001!
        '
        'Line140
        '
        Me.Line140.Height = 0.2666667!
        Me.Line140.Left = 6.266663!
        Me.Line140.LineWeight = 1!
        Me.Line140.Name = "Line140"
        Me.Line140.Top = 2.933334!
        Me.Line140.Width = 0!
        Me.Line140.X1 = 6.266663!
        Me.Line140.X2 = 6.266663!
        Me.Line140.Y1 = 2.933334!
        Me.Line140.Y2 = 3.200001!
        '
        'Line141
        '
        Me.Line141.Height = 0.2666674!
        Me.Line141.Left = 7.26666!
        Me.Line141.LineWeight = 1!
        Me.Line141.Name = "Line141"
        Me.Line141.Top = 2.933333!
        Me.Line141.Width = 0!
        Me.Line141.X1 = 7.26666!
        Me.Line141.X2 = 7.26666!
        Me.Line141.Y1 = 2.933333!
        Me.Line141.Y2 = 3.200001!
        '
        'Line142
        '
        Me.Line142.Height = 0!
        Me.Line142.Left = 0.06666667!
        Me.Line142.LineWeight = 1!
        Me.Line142.Name = "Line142"
        Me.Line142.Top = 3.2!
        Me.Line142.Width = 7.2!
        Me.Line142.X1 = 0.06666667!
        Me.Line142.X2 = 7.266667!
        Me.Line142.Y1 = 3.2!
        Me.Line142.Y2 = 3.2!
        '
        'Line143
        '
        Me.Line143.Height = 0.2666667!
        Me.Line143.Left = 0.06666667!
        Me.Line143.LineWeight = 1!
        Me.Line143.Name = "Line143"
        Me.Line143.Top = 3.2!
        Me.Line143.Width = 0!
        Me.Line143.X1 = 0.06666667!
        Me.Line143.X2 = 0.06666667!
        Me.Line143.Y1 = 3.2!
        Me.Line143.Y2 = 3.466667!
        '
        'Line144
        '
        Me.Line144.Height = 0.2666667!
        Me.Line144.Left = 0.5333334!
        Me.Line144.LineWeight = 1!
        Me.Line144.Name = "Line144"
        Me.Line144.Top = 3.2!
        Me.Line144.Width = 0!
        Me.Line144.X1 = 0.5333334!
        Me.Line144.X2 = 0.5333334!
        Me.Line144.Y1 = 3.2!
        Me.Line144.Y2 = 3.466667!
        '
        'Line145
        '
        Me.Line145.Height = 0.2666667!
        Me.Line145.Left = 1.333333!
        Me.Line145.LineWeight = 1!
        Me.Line145.Name = "Line145"
        Me.Line145.Top = 3.2!
        Me.Line145.Width = 0!
        Me.Line145.X1 = 1.333333!
        Me.Line145.X2 = 1.333333!
        Me.Line145.Y1 = 3.2!
        Me.Line145.Y2 = 3.466667!
        '
        'Line146
        '
        Me.Line146.Height = 0.2666667!
        Me.Line146.Left = 1.995834!
        Me.Line146.LineWeight = 1!
        Me.Line146.Name = "Line146"
        Me.Line146.Top = 3.2!
        Me.Line146.Width = 0!
        Me.Line146.X1 = 1.995834!
        Me.Line146.X2 = 1.995834!
        Me.Line146.Y1 = 3.2!
        Me.Line146.Y2 = 3.466667!
        '
        'Line147
        '
        Me.Line147.Height = 0.2666667!
        Me.Line147.Left = 2.6!
        Me.Line147.LineWeight = 1!
        Me.Line147.Name = "Line147"
        Me.Line147.Top = 3.2!
        Me.Line147.Width = 0!
        Me.Line147.X1 = 2.6!
        Me.Line147.X2 = 2.6!
        Me.Line147.Y1 = 3.2!
        Me.Line147.Y2 = 3.466667!
        '
        'Line148
        '
        Me.Line148.Height = 0.2666667!
        Me.Line148.Left = 4.133333!
        Me.Line148.LineWeight = 1!
        Me.Line148.Name = "Line148"
        Me.Line148.Top = 3.2!
        Me.Line148.Width = 0!
        Me.Line148.X1 = 4.133333!
        Me.Line148.X2 = 4.133333!
        Me.Line148.Y1 = 3.2!
        Me.Line148.Y2 = 3.466667!
        '
        'Line149
        '
        Me.Line149.Height = 0.2666667!
        Me.Line149.Left = 5.199998!
        Me.Line149.LineWeight = 1!
        Me.Line149.Name = "Line149"
        Me.Line149.Top = 3.200001!
        Me.Line149.Width = 0!
        Me.Line149.X1 = 5.199998!
        Me.Line149.X2 = 5.199998!
        Me.Line149.Y1 = 3.200001!
        Me.Line149.Y2 = 3.466667!
        '
        'Line150
        '
        Me.Line150.Height = 0.2666667!
        Me.Line150.Left = 5.733331!
        Me.Line150.LineWeight = 1!
        Me.Line150.Name = "Line150"
        Me.Line150.Top = 3.2!
        Me.Line150.Width = 0!
        Me.Line150.X1 = 5.733331!
        Me.Line150.X2 = 5.733331!
        Me.Line150.Y1 = 3.2!
        Me.Line150.Y2 = 3.466667!
        '
        'Line151
        '
        Me.Line151.Height = 0.2666667!
        Me.Line151.Left = 6.266663!
        Me.Line151.LineWeight = 1!
        Me.Line151.Name = "Line151"
        Me.Line151.Top = 3.2!
        Me.Line151.Width = 0!
        Me.Line151.X1 = 6.266663!
        Me.Line151.X2 = 6.266663!
        Me.Line151.Y1 = 3.2!
        Me.Line151.Y2 = 3.466667!
        '
        'Line152
        '
        Me.Line152.Height = 0.2666667!
        Me.Line152.Left = 7.26666!
        Me.Line152.LineWeight = 1!
        Me.Line152.Name = "Line152"
        Me.Line152.Top = 3.2!
        Me.Line152.Width = 0!
        Me.Line152.X1 = 7.26666!
        Me.Line152.X2 = 7.26666!
        Me.Line152.Y1 = 3.2!
        Me.Line152.Y2 = 3.466667!
        '
        'Line153
        '
        Me.Line153.Height = 0!
        Me.Line153.Left = 0.06666667!
        Me.Line153.LineWeight = 1!
        Me.Line153.Name = "Line153"
        Me.Line153.Top = 3.466667!
        Me.Line153.Width = 7.2!
        Me.Line153.X1 = 0.06666667!
        Me.Line153.X2 = 7.266667!
        Me.Line153.Y1 = 3.466667!
        Me.Line153.Y2 = 3.466667!
        '
        'Line154
        '
        Me.Line154.Height = 0.2666667!
        Me.Line154.Left = 0.06666667!
        Me.Line154.LineWeight = 1!
        Me.Line154.Name = "Line154"
        Me.Line154.Top = 3.466667!
        Me.Line154.Width = 0!
        Me.Line154.X1 = 0.06666667!
        Me.Line154.X2 = 0.06666667!
        Me.Line154.Y1 = 3.466667!
        Me.Line154.Y2 = 3.733333!
        '
        'Line155
        '
        Me.Line155.Height = 0.2666667!
        Me.Line155.Left = 0.5333334!
        Me.Line155.LineWeight = 1!
        Me.Line155.Name = "Line155"
        Me.Line155.Top = 3.466667!
        Me.Line155.Width = 0!
        Me.Line155.X1 = 0.5333334!
        Me.Line155.X2 = 0.5333334!
        Me.Line155.Y1 = 3.466667!
        Me.Line155.Y2 = 3.733333!
        '
        'Line156
        '
        Me.Line156.Height = 0.2666667!
        Me.Line156.Left = 1.333333!
        Me.Line156.LineWeight = 1!
        Me.Line156.Name = "Line156"
        Me.Line156.Top = 3.466667!
        Me.Line156.Width = 0!
        Me.Line156.X1 = 1.333333!
        Me.Line156.X2 = 1.333333!
        Me.Line156.Y1 = 3.466667!
        Me.Line156.Y2 = 3.733333!
        '
        'Line157
        '
        Me.Line157.Height = 0.2666667!
        Me.Line157.Left = 1.995834!
        Me.Line157.LineWeight = 1!
        Me.Line157.Name = "Line157"
        Me.Line157.Top = 3.466667!
        Me.Line157.Width = 0!
        Me.Line157.X1 = 1.995834!
        Me.Line157.X2 = 1.995834!
        Me.Line157.Y1 = 3.466667!
        Me.Line157.Y2 = 3.733333!
        '
        'Line158
        '
        Me.Line158.Height = 0.2666667!
        Me.Line158.Left = 2.6!
        Me.Line158.LineWeight = 1!
        Me.Line158.Name = "Line158"
        Me.Line158.Top = 3.466667!
        Me.Line158.Width = 0!
        Me.Line158.X1 = 2.6!
        Me.Line158.X2 = 2.6!
        Me.Line158.Y1 = 3.466667!
        Me.Line158.Y2 = 3.733333!
        '
        'Line159
        '
        Me.Line159.Height = 0.2666667!
        Me.Line159.Left = 4.133333!
        Me.Line159.LineWeight = 1!
        Me.Line159.Name = "Line159"
        Me.Line159.Top = 3.466667!
        Me.Line159.Width = 0!
        Me.Line159.X1 = 4.133333!
        Me.Line159.X2 = 4.133333!
        Me.Line159.Y1 = 3.466667!
        Me.Line159.Y2 = 3.733333!
        '
        'Line160
        '
        Me.Line160.Height = 0.2666667!
        Me.Line160.Left = 5.199998!
        Me.Line160.LineWeight = 1!
        Me.Line160.Name = "Line160"
        Me.Line160.Top = 3.466667!
        Me.Line160.Width = 0!
        Me.Line160.X1 = 5.199998!
        Me.Line160.X2 = 5.199998!
        Me.Line160.Y1 = 3.466667!
        Me.Line160.Y2 = 3.733333!
        '
        'Line161
        '
        Me.Line161.Height = 0.2666667!
        Me.Line161.Left = 5.733331!
        Me.Line161.LineWeight = 1!
        Me.Line161.Name = "Line161"
        Me.Line161.Top = 3.466667!
        Me.Line161.Width = 0!
        Me.Line161.X1 = 5.733331!
        Me.Line161.X2 = 5.733331!
        Me.Line161.Y1 = 3.466667!
        Me.Line161.Y2 = 3.733333!
        '
        'Line162
        '
        Me.Line162.Height = 0.2666667!
        Me.Line162.Left = 6.266663!
        Me.Line162.LineWeight = 1!
        Me.Line162.Name = "Line162"
        Me.Line162.Top = 3.466667!
        Me.Line162.Width = 0!
        Me.Line162.X1 = 6.266663!
        Me.Line162.X2 = 6.266663!
        Me.Line162.Y1 = 3.466667!
        Me.Line162.Y2 = 3.733333!
        '
        'Line163
        '
        Me.Line163.Height = 0.2666667!
        Me.Line163.Left = 7.26666!
        Me.Line163.LineWeight = 1!
        Me.Line163.Name = "Line163"
        Me.Line163.Top = 3.466667!
        Me.Line163.Width = 0!
        Me.Line163.X1 = 7.26666!
        Me.Line163.X2 = 7.26666!
        Me.Line163.Y1 = 3.466667!
        Me.Line163.Y2 = 3.733333!
        '
        'Line164
        '
        Me.Line164.Height = 0!
        Me.Line164.Left = 0.06666667!
        Me.Line164.LineWeight = 1!
        Me.Line164.Name = "Line164"
        Me.Line164.Top = 3.733333!
        Me.Line164.Width = 7.2!
        Me.Line164.X1 = 0.06666667!
        Me.Line164.X2 = 7.266667!
        Me.Line164.Y1 = 3.733333!
        Me.Line164.Y2 = 3.733333!
        '
        'Line165
        '
        Me.Line165.Height = 0.2666667!
        Me.Line165.Left = 0.06666667!
        Me.Line165.LineWeight = 1!
        Me.Line165.Name = "Line165"
        Me.Line165.Top = 3.733333!
        Me.Line165.Width = 0!
        Me.Line165.X1 = 0.06666667!
        Me.Line165.X2 = 0.06666667!
        Me.Line165.Y1 = 3.733333!
        Me.Line165.Y2 = 4!
        '
        'Line166
        '
        Me.Line166.Height = 0.2666667!
        Me.Line166.Left = 0.5333334!
        Me.Line166.LineWeight = 1!
        Me.Line166.Name = "Line166"
        Me.Line166.Top = 3.733333!
        Me.Line166.Width = 0!
        Me.Line166.X1 = 0.5333334!
        Me.Line166.X2 = 0.5333334!
        Me.Line166.Y1 = 3.733333!
        Me.Line166.Y2 = 4!
        '
        'Line167
        '
        Me.Line167.Height = 0.2666667!
        Me.Line167.Left = 1.333333!
        Me.Line167.LineWeight = 1!
        Me.Line167.Name = "Line167"
        Me.Line167.Top = 3.733333!
        Me.Line167.Width = 0!
        Me.Line167.X1 = 1.333333!
        Me.Line167.X2 = 1.333333!
        Me.Line167.Y1 = 3.733333!
        Me.Line167.Y2 = 4!
        '
        'Line168
        '
        Me.Line168.Height = 0.2666667!
        Me.Line168.Left = 1.995834!
        Me.Line168.LineWeight = 1!
        Me.Line168.Name = "Line168"
        Me.Line168.Top = 3.733333!
        Me.Line168.Width = 0!
        Me.Line168.X1 = 1.995834!
        Me.Line168.X2 = 1.995834!
        Me.Line168.Y1 = 3.733333!
        Me.Line168.Y2 = 4!
        '
        'Line169
        '
        Me.Line169.Height = 0.2666667!
        Me.Line169.Left = 2.6!
        Me.Line169.LineWeight = 1!
        Me.Line169.Name = "Line169"
        Me.Line169.Top = 3.733333!
        Me.Line169.Width = 0!
        Me.Line169.X1 = 2.6!
        Me.Line169.X2 = 2.6!
        Me.Line169.Y1 = 3.733333!
        Me.Line169.Y2 = 4!
        '
        'Line170
        '
        Me.Line170.Height = 0.2666667!
        Me.Line170.Left = 4.133333!
        Me.Line170.LineWeight = 1!
        Me.Line170.Name = "Line170"
        Me.Line170.Top = 3.733333!
        Me.Line170.Width = 0!
        Me.Line170.X1 = 4.133333!
        Me.Line170.X2 = 4.133333!
        Me.Line170.Y1 = 3.733333!
        Me.Line170.Y2 = 4!
        '
        'Line171
        '
        Me.Line171.Height = 0.2666667!
        Me.Line171.Left = 5.199998!
        Me.Line171.LineWeight = 1!
        Me.Line171.Name = "Line171"
        Me.Line171.Top = 3.733333!
        Me.Line171.Width = 0!
        Me.Line171.X1 = 5.199998!
        Me.Line171.X2 = 5.199998!
        Me.Line171.Y1 = 3.733333!
        Me.Line171.Y2 = 4!
        '
        'Line172
        '
        Me.Line172.Height = 0.2666667!
        Me.Line172.Left = 5.733331!
        Me.Line172.LineWeight = 1!
        Me.Line172.Name = "Line172"
        Me.Line172.Top = 3.733333!
        Me.Line172.Width = 0!
        Me.Line172.X1 = 5.733331!
        Me.Line172.X2 = 5.733331!
        Me.Line172.Y1 = 3.733333!
        Me.Line172.Y2 = 4!
        '
        'Line173
        '
        Me.Line173.Height = 0.2666667!
        Me.Line173.Left = 6.266663!
        Me.Line173.LineWeight = 1!
        Me.Line173.Name = "Line173"
        Me.Line173.Top = 3.733333!
        Me.Line173.Width = 0!
        Me.Line173.X1 = 6.266663!
        Me.Line173.X2 = 6.266663!
        Me.Line173.Y1 = 3.733333!
        Me.Line173.Y2 = 4!
        '
        'Line174
        '
        Me.Line174.Height = 0.2666667!
        Me.Line174.Left = 7.26666!
        Me.Line174.LineWeight = 1!
        Me.Line174.Name = "Line174"
        Me.Line174.Top = 3.733333!
        Me.Line174.Width = 0!
        Me.Line174.X1 = 7.26666!
        Me.Line174.X2 = 7.26666!
        Me.Line174.Y1 = 3.733333!
        Me.Line174.Y2 = 4!
        '
        'Line175
        '
        Me.Line175.Height = 0!
        Me.Line175.Left = 0.06666667!
        Me.Line175.LineWeight = 1!
        Me.Line175.Name = "Line175"
        Me.Line175.Top = 4!
        Me.Line175.Width = 7.2!
        Me.Line175.X1 = 0.06666667!
        Me.Line175.X2 = 7.266667!
        Me.Line175.Y1 = 4!
        Me.Line175.Y2 = 4!
        '
        'Line176
        '
        Me.Line176.Height = 0.2666674!
        Me.Line176.Left = 0.06666667!
        Me.Line176.LineWeight = 1!
        Me.Line176.Name = "Line176"
        Me.Line176.Top = 4!
        Me.Line176.Width = 0!
        Me.Line176.X1 = 0.06666667!
        Me.Line176.X2 = 0.06666667!
        Me.Line176.Y1 = 4!
        Me.Line176.Y2 = 4.266667!
        '
        'Line177
        '
        Me.Line177.Height = 0.2666674!
        Me.Line177.Left = 0.5333334!
        Me.Line177.LineWeight = 1!
        Me.Line177.Name = "Line177"
        Me.Line177.Top = 4!
        Me.Line177.Width = 0!
        Me.Line177.X1 = 0.5333334!
        Me.Line177.X2 = 0.5333334!
        Me.Line177.Y1 = 4!
        Me.Line177.Y2 = 4.266667!
        '
        'Line178
        '
        Me.Line178.Height = 0.2666674!
        Me.Line178.Left = 1.333333!
        Me.Line178.LineWeight = 1!
        Me.Line178.Name = "Line178"
        Me.Line178.Top = 4!
        Me.Line178.Width = 0!
        Me.Line178.X1 = 1.333333!
        Me.Line178.X2 = 1.333333!
        Me.Line178.Y1 = 4!
        Me.Line178.Y2 = 4.266667!
        '
        'Line179
        '
        Me.Line179.Height = 0.2666674!
        Me.Line179.Left = 1.995834!
        Me.Line179.LineWeight = 1!
        Me.Line179.Name = "Line179"
        Me.Line179.Top = 4!
        Me.Line179.Width = 0!
        Me.Line179.X1 = 1.995834!
        Me.Line179.X2 = 1.995834!
        Me.Line179.Y1 = 4!
        Me.Line179.Y2 = 4.266667!
        '
        'Line180
        '
        Me.Line180.Height = 0.2666674!
        Me.Line180.Left = 2.6!
        Me.Line180.LineWeight = 1!
        Me.Line180.Name = "Line180"
        Me.Line180.Top = 4!
        Me.Line180.Width = 0!
        Me.Line180.X1 = 2.6!
        Me.Line180.X2 = 2.6!
        Me.Line180.Y1 = 4!
        Me.Line180.Y2 = 4.266667!
        '
        'Line181
        '
        Me.Line181.Height = 0.2666674!
        Me.Line181.Left = 4.133333!
        Me.Line181.LineWeight = 1!
        Me.Line181.Name = "Line181"
        Me.Line181.Top = 4!
        Me.Line181.Width = 0!
        Me.Line181.X1 = 4.133333!
        Me.Line181.X2 = 4.133333!
        Me.Line181.Y1 = 4!
        Me.Line181.Y2 = 4.266667!
        '
        'Line182
        '
        Me.Line182.Height = 0.2666674!
        Me.Line182.Left = 5.199998!
        Me.Line182.LineWeight = 1!
        Me.Line182.Name = "Line182"
        Me.Line182.Top = 4!
        Me.Line182.Width = 0!
        Me.Line182.X1 = 5.199998!
        Me.Line182.X2 = 5.199998!
        Me.Line182.Y1 = 4!
        Me.Line182.Y2 = 4.266667!
        '
        'Line183
        '
        Me.Line183.Height = 0.2666674!
        Me.Line183.Left = 5.733331!
        Me.Line183.LineWeight = 1!
        Me.Line183.Name = "Line183"
        Me.Line183.Top = 4!
        Me.Line183.Width = 0!
        Me.Line183.X1 = 5.733331!
        Me.Line183.X2 = 5.733331!
        Me.Line183.Y1 = 4!
        Me.Line183.Y2 = 4.266667!
        '
        'Line184
        '
        Me.Line184.Height = 0.2666674!
        Me.Line184.Left = 6.266663!
        Me.Line184.LineWeight = 1!
        Me.Line184.Name = "Line184"
        Me.Line184.Top = 4!
        Me.Line184.Width = 0!
        Me.Line184.X1 = 6.266663!
        Me.Line184.X2 = 6.266663!
        Me.Line184.Y1 = 4!
        Me.Line184.Y2 = 4.266667!
        '
        'Line185
        '
        Me.Line185.Height = 0.2666674!
        Me.Line185.Left = 7.26666!
        Me.Line185.LineWeight = 1!
        Me.Line185.Name = "Line185"
        Me.Line185.Top = 4!
        Me.Line185.Width = 0!
        Me.Line185.X1 = 7.26666!
        Me.Line185.X2 = 7.26666!
        Me.Line185.Y1 = 4!
        Me.Line185.Y2 = 4.266667!
        '
        'Line186
        '
        Me.Line186.Height = 0!
        Me.Line186.Left = 0.06666667!
        Me.Line186.LineWeight = 1!
        Me.Line186.Name = "Line186"
        Me.Line186.Top = 4.266667!
        Me.Line186.Width = 7.2!
        Me.Line186.X1 = 0.06666667!
        Me.Line186.X2 = 7.266667!
        Me.Line186.Y1 = 4.266667!
        Me.Line186.Y2 = 4.266667!
        '
        'Line187
        '
        Me.Line187.Height = 0.2666659!
        Me.Line187.Left = 0.06666667!
        Me.Line187.LineWeight = 1!
        Me.Line187.Name = "Line187"
        Me.Line187.Top = 4.266667!
        Me.Line187.Width = 0!
        Me.Line187.X1 = 0.06666667!
        Me.Line187.X2 = 0.06666667!
        Me.Line187.Y1 = 4.266667!
        Me.Line187.Y2 = 4.533333!
        '
        'Line188
        '
        Me.Line188.Height = 0.2666659!
        Me.Line188.Left = 0.5333334!
        Me.Line188.LineWeight = 1!
        Me.Line188.Name = "Line188"
        Me.Line188.Top = 4.266667!
        Me.Line188.Width = 0!
        Me.Line188.X1 = 0.5333334!
        Me.Line188.X2 = 0.5333334!
        Me.Line188.Y1 = 4.266667!
        Me.Line188.Y2 = 4.533333!
        '
        'Line189
        '
        Me.Line189.Height = 0.2666659!
        Me.Line189.Left = 1.333333!
        Me.Line189.LineWeight = 1!
        Me.Line189.Name = "Line189"
        Me.Line189.Top = 4.266667!
        Me.Line189.Width = 0!
        Me.Line189.X1 = 1.333333!
        Me.Line189.X2 = 1.333333!
        Me.Line189.Y1 = 4.266667!
        Me.Line189.Y2 = 4.533333!
        '
        'Line190
        '
        Me.Line190.Height = 0.2666659!
        Me.Line190.Left = 1.995834!
        Me.Line190.LineWeight = 1!
        Me.Line190.Name = "Line190"
        Me.Line190.Top = 4.266667!
        Me.Line190.Width = 0!
        Me.Line190.X1 = 1.995834!
        Me.Line190.X2 = 1.995834!
        Me.Line190.Y1 = 4.266667!
        Me.Line190.Y2 = 4.533333!
        '
        'Line191
        '
        Me.Line191.Height = 0.2666659!
        Me.Line191.Left = 2.6!
        Me.Line191.LineWeight = 1!
        Me.Line191.Name = "Line191"
        Me.Line191.Top = 4.266667!
        Me.Line191.Width = 0!
        Me.Line191.X1 = 2.6!
        Me.Line191.X2 = 2.6!
        Me.Line191.Y1 = 4.266667!
        Me.Line191.Y2 = 4.533333!
        '
        'Line192
        '
        Me.Line192.Height = 0.2666659!
        Me.Line192.Left = 4.133333!
        Me.Line192.LineWeight = 1!
        Me.Line192.Name = "Line192"
        Me.Line192.Top = 4.266667!
        Me.Line192.Width = 0!
        Me.Line192.X1 = 4.133333!
        Me.Line192.X2 = 4.133333!
        Me.Line192.Y1 = 4.266667!
        Me.Line192.Y2 = 4.533333!
        '
        'Line193
        '
        Me.Line193.Height = 0.2666659!
        Me.Line193.Left = 5.199998!
        Me.Line193.LineWeight = 1!
        Me.Line193.Name = "Line193"
        Me.Line193.Top = 4.266667!
        Me.Line193.Width = 0!
        Me.Line193.X1 = 5.199998!
        Me.Line193.X2 = 5.199998!
        Me.Line193.Y1 = 4.266667!
        Me.Line193.Y2 = 4.533333!
        '
        'Line194
        '
        Me.Line194.Height = 0.2666659!
        Me.Line194.Left = 5.733331!
        Me.Line194.LineWeight = 1!
        Me.Line194.Name = "Line194"
        Me.Line194.Top = 4.266667!
        Me.Line194.Width = 0!
        Me.Line194.X1 = 5.733331!
        Me.Line194.X2 = 5.733331!
        Me.Line194.Y1 = 4.266667!
        Me.Line194.Y2 = 4.533333!
        '
        'Line195
        '
        Me.Line195.Height = 0.2666659!
        Me.Line195.Left = 6.266663!
        Me.Line195.LineWeight = 1!
        Me.Line195.Name = "Line195"
        Me.Line195.Top = 4.266667!
        Me.Line195.Width = 0!
        Me.Line195.X1 = 6.266663!
        Me.Line195.X2 = 6.266663!
        Me.Line195.Y1 = 4.266667!
        Me.Line195.Y2 = 4.533333!
        '
        'Line196
        '
        Me.Line196.Height = 0.2666659!
        Me.Line196.Left = 7.26666!
        Me.Line196.LineWeight = 1!
        Me.Line196.Name = "Line196"
        Me.Line196.Top = 4.266667!
        Me.Line196.Width = 0!
        Me.Line196.X1 = 7.26666!
        Me.Line196.X2 = 7.26666!
        Me.Line196.Y1 = 4.266667!
        Me.Line196.Y2 = 4.533333!
        '
        'Line197
        '
        Me.Line197.Height = 0!
        Me.Line197.Left = 0.06666667!
        Me.Line197.LineWeight = 1!
        Me.Line197.Name = "Line197"
        Me.Line197.Top = 4.533333!
        Me.Line197.Width = 7.2!
        Me.Line197.X1 = 0.06666667!
        Me.Line197.X2 = 7.266667!
        Me.Line197.Y1 = 4.533333!
        Me.Line197.Y2 = 4.533333!
        '
        'Line198
        '
        Me.Line198.Height = 0.2666674!
        Me.Line198.Left = 0.06666667!
        Me.Line198.LineWeight = 1!
        Me.Line198.Name = "Line198"
        Me.Line198.Top = 4.533333!
        Me.Line198.Width = 0!
        Me.Line198.X1 = 0.06666667!
        Me.Line198.X2 = 0.06666667!
        Me.Line198.Y1 = 4.533333!
        Me.Line198.Y2 = 4.800001!
        '
        'Line199
        '
        Me.Line199.Height = 0.2666674!
        Me.Line199.Left = 0.5333334!
        Me.Line199.LineWeight = 1!
        Me.Line199.Name = "Line199"
        Me.Line199.Top = 4.533333!
        Me.Line199.Width = 0!
        Me.Line199.X1 = 0.5333334!
        Me.Line199.X2 = 0.5333334!
        Me.Line199.Y1 = 4.533333!
        Me.Line199.Y2 = 4.800001!
        '
        'Line200
        '
        Me.Line200.Height = 0.2666674!
        Me.Line200.Left = 1.333333!
        Me.Line200.LineWeight = 1!
        Me.Line200.Name = "Line200"
        Me.Line200.Top = 4.533333!
        Me.Line200.Width = 0!
        Me.Line200.X1 = 1.333333!
        Me.Line200.X2 = 1.333333!
        Me.Line200.Y1 = 4.533333!
        Me.Line200.Y2 = 4.800001!
        '
        'Line201
        '
        Me.Line201.Height = 0.2666674!
        Me.Line201.Left = 1.995834!
        Me.Line201.LineWeight = 1!
        Me.Line201.Name = "Line201"
        Me.Line201.Top = 4.533333!
        Me.Line201.Width = 0!
        Me.Line201.X1 = 1.995834!
        Me.Line201.X2 = 1.995834!
        Me.Line201.Y1 = 4.533333!
        Me.Line201.Y2 = 4.800001!
        '
        'Line202
        '
        Me.Line202.Height = 0.2666674!
        Me.Line202.Left = 2.6!
        Me.Line202.LineWeight = 1!
        Me.Line202.Name = "Line202"
        Me.Line202.Top = 4.533333!
        Me.Line202.Width = 0!
        Me.Line202.X1 = 2.6!
        Me.Line202.X2 = 2.6!
        Me.Line202.Y1 = 4.533333!
        Me.Line202.Y2 = 4.800001!
        '
        'Line203
        '
        Me.Line203.Height = 0.2666674!
        Me.Line203.Left = 4.133333!
        Me.Line203.LineWeight = 1!
        Me.Line203.Name = "Line203"
        Me.Line203.Top = 4.533333!
        Me.Line203.Width = 0!
        Me.Line203.X1 = 4.133333!
        Me.Line203.X2 = 4.133333!
        Me.Line203.Y1 = 4.533333!
        Me.Line203.Y2 = 4.800001!
        '
        'Line204
        '
        Me.Line204.Height = 0.2666674!
        Me.Line204.Left = 5.199998!
        Me.Line204.LineWeight = 1!
        Me.Line204.Name = "Line204"
        Me.Line204.Top = 4.533333!
        Me.Line204.Width = 0!
        Me.Line204.X1 = 5.199998!
        Me.Line204.X2 = 5.199998!
        Me.Line204.Y1 = 4.533333!
        Me.Line204.Y2 = 4.800001!
        '
        'Line205
        '
        Me.Line205.Height = 0.2666674!
        Me.Line205.Left = 5.733331!
        Me.Line205.LineWeight = 1!
        Me.Line205.Name = "Line205"
        Me.Line205.Top = 4.533333!
        Me.Line205.Width = 0!
        Me.Line205.X1 = 5.733331!
        Me.Line205.X2 = 5.733331!
        Me.Line205.Y1 = 4.533333!
        Me.Line205.Y2 = 4.800001!
        '
        'Line206
        '
        Me.Line206.Height = 0.2666674!
        Me.Line206.Left = 6.266663!
        Me.Line206.LineWeight = 1!
        Me.Line206.Name = "Line206"
        Me.Line206.Top = 4.533333!
        Me.Line206.Width = 0!
        Me.Line206.X1 = 6.266663!
        Me.Line206.X2 = 6.266663!
        Me.Line206.Y1 = 4.533333!
        Me.Line206.Y2 = 4.800001!
        '
        'Line207
        '
        Me.Line207.Height = 0.2666674!
        Me.Line207.Left = 7.26666!
        Me.Line207.LineWeight = 1!
        Me.Line207.Name = "Line207"
        Me.Line207.Top = 4.533333!
        Me.Line207.Width = 0!
        Me.Line207.X1 = 7.26666!
        Me.Line207.X2 = 7.26666!
        Me.Line207.Y1 = 4.533333!
        Me.Line207.Y2 = 4.800001!
        '
        'Line208
        '
        Me.Line208.Height = 0!
        Me.Line208.Left = 0.06666667!
        Me.Line208.LineWeight = 1!
        Me.Line208.Name = "Line208"
        Me.Line208.Top = 4.800001!
        Me.Line208.Width = 7.2!
        Me.Line208.X1 = 0.06666667!
        Me.Line208.X2 = 7.266667!
        Me.Line208.Y1 = 4.800001!
        Me.Line208.Y2 = 4.800001!
        '
        'Line209
        '
        Me.Line209.Height = 0.2666669!
        Me.Line209.Left = 0.06666667!
        Me.Line209.LineWeight = 1!
        Me.Line209.Name = "Line209"
        Me.Line209.Top = 4.800001!
        Me.Line209.Width = 0!
        Me.Line209.X1 = 0.06666667!
        Me.Line209.X2 = 0.06666667!
        Me.Line209.Y1 = 4.800001!
        Me.Line209.Y2 = 5.066668!
        '
        'Line210
        '
        Me.Line210.Height = 0.2666669!
        Me.Line210.Left = 0.5333334!
        Me.Line210.LineWeight = 1!
        Me.Line210.Name = "Line210"
        Me.Line210.Top = 4.800001!
        Me.Line210.Width = 0!
        Me.Line210.X1 = 0.5333334!
        Me.Line210.X2 = 0.5333334!
        Me.Line210.Y1 = 4.800001!
        Me.Line210.Y2 = 5.066668!
        '
        'Line211
        '
        Me.Line211.Height = 0.2666669!
        Me.Line211.Left = 1.333333!
        Me.Line211.LineWeight = 1!
        Me.Line211.Name = "Line211"
        Me.Line211.Top = 4.800001!
        Me.Line211.Width = 0!
        Me.Line211.X1 = 1.333333!
        Me.Line211.X2 = 1.333333!
        Me.Line211.Y1 = 4.800001!
        Me.Line211.Y2 = 5.066668!
        '
        'Line212
        '
        Me.Line212.Height = 0.2666669!
        Me.Line212.Left = 1.995834!
        Me.Line212.LineWeight = 1!
        Me.Line212.Name = "Line212"
        Me.Line212.Top = 4.800001!
        Me.Line212.Width = 0!
        Me.Line212.X1 = 1.995834!
        Me.Line212.X2 = 1.995834!
        Me.Line212.Y1 = 4.800001!
        Me.Line212.Y2 = 5.066668!
        '
        'Line213
        '
        Me.Line213.Height = 0.2666669!
        Me.Line213.Left = 2.6!
        Me.Line213.LineWeight = 1!
        Me.Line213.Name = "Line213"
        Me.Line213.Top = 4.800001!
        Me.Line213.Width = 0!
        Me.Line213.X1 = 2.6!
        Me.Line213.X2 = 2.6!
        Me.Line213.Y1 = 4.800001!
        Me.Line213.Y2 = 5.066668!
        '
        'Line214
        '
        Me.Line214.Height = 0.2666669!
        Me.Line214.Left = 4.133333!
        Me.Line214.LineWeight = 1!
        Me.Line214.Name = "Line214"
        Me.Line214.Top = 4.800001!
        Me.Line214.Width = 0!
        Me.Line214.X1 = 4.133333!
        Me.Line214.X2 = 4.133333!
        Me.Line214.Y1 = 4.800001!
        Me.Line214.Y2 = 5.066668!
        '
        'Line215
        '
        Me.Line215.Height = 0.2666669!
        Me.Line215.Left = 5.199998!
        Me.Line215.LineWeight = 1!
        Me.Line215.Name = "Line215"
        Me.Line215.Top = 4.800001!
        Me.Line215.Width = 0!
        Me.Line215.X1 = 5.199998!
        Me.Line215.X2 = 5.199998!
        Me.Line215.Y1 = 4.800001!
        Me.Line215.Y2 = 5.066668!
        '
        'Line216
        '
        Me.Line216.Height = 0.2666669!
        Me.Line216.Left = 5.733331!
        Me.Line216.LineWeight = 1!
        Me.Line216.Name = "Line216"
        Me.Line216.Top = 4.800001!
        Me.Line216.Width = 0!
        Me.Line216.X1 = 5.733331!
        Me.Line216.X2 = 5.733331!
        Me.Line216.Y1 = 4.800001!
        Me.Line216.Y2 = 5.066668!
        '
        'Line217
        '
        Me.Line217.Height = 0.2666669!
        Me.Line217.Left = 6.266663!
        Me.Line217.LineWeight = 1!
        Me.Line217.Name = "Line217"
        Me.Line217.Top = 4.800001!
        Me.Line217.Width = 0!
        Me.Line217.X1 = 6.266663!
        Me.Line217.X2 = 6.266663!
        Me.Line217.Y1 = 4.800001!
        Me.Line217.Y2 = 5.066668!
        '
        'Line218
        '
        Me.Line218.Height = 0.2666669!
        Me.Line218.Left = 7.26666!
        Me.Line218.LineWeight = 1!
        Me.Line218.Name = "Line218"
        Me.Line218.Top = 4.800001!
        Me.Line218.Width = 0!
        Me.Line218.X1 = 7.26666!
        Me.Line218.X2 = 7.26666!
        Me.Line218.Y1 = 4.800001!
        Me.Line218.Y2 = 5.066668!
        '
        'Line219
        '
        Me.Line219.Height = 0!
        Me.Line219.Left = 0.06666667!
        Me.Line219.LineWeight = 1!
        Me.Line219.Name = "Line219"
        Me.Line219.Top = 5.066667!
        Me.Line219.Width = 7.2!
        Me.Line219.X1 = 0.06666667!
        Me.Line219.X2 = 7.266667!
        Me.Line219.Y1 = 5.066667!
        Me.Line219.Y2 = 5.066667!
        '
        'Line220
        '
        Me.Line220.Height = 0.2666674!
        Me.Line220.Left = 0.06666667!
        Me.Line220.LineWeight = 1!
        Me.Line220.Name = "Line220"
        Me.Line220.Top = 5.066667!
        Me.Line220.Width = 0!
        Me.Line220.X1 = 0.06666667!
        Me.Line220.X2 = 0.06666667!
        Me.Line220.Y1 = 5.066667!
        Me.Line220.Y2 = 5.333334!
        '
        'Line221
        '
        Me.Line221.Height = 0.2666674!
        Me.Line221.Left = 0.5333334!
        Me.Line221.LineWeight = 1!
        Me.Line221.Name = "Line221"
        Me.Line221.Top = 5.066667!
        Me.Line221.Width = 0!
        Me.Line221.X1 = 0.5333334!
        Me.Line221.X2 = 0.5333334!
        Me.Line221.Y1 = 5.066667!
        Me.Line221.Y2 = 5.333334!
        '
        'Line222
        '
        Me.Line222.Height = 0.2666674!
        Me.Line222.Left = 1.333333!
        Me.Line222.LineWeight = 1!
        Me.Line222.Name = "Line222"
        Me.Line222.Top = 5.066667!
        Me.Line222.Width = 0!
        Me.Line222.X1 = 1.333333!
        Me.Line222.X2 = 1.333333!
        Me.Line222.Y1 = 5.066667!
        Me.Line222.Y2 = 5.333334!
        '
        'Line223
        '
        Me.Line223.Height = 0.2666674!
        Me.Line223.Left = 1.995834!
        Me.Line223.LineWeight = 1!
        Me.Line223.Name = "Line223"
        Me.Line223.Top = 5.066667!
        Me.Line223.Width = 0!
        Me.Line223.X1 = 1.995834!
        Me.Line223.X2 = 1.995834!
        Me.Line223.Y1 = 5.066667!
        Me.Line223.Y2 = 5.333334!
        '
        'Line224
        '
        Me.Line224.Height = 0.2666674!
        Me.Line224.Left = 2.6!
        Me.Line224.LineWeight = 1!
        Me.Line224.Name = "Line224"
        Me.Line224.Top = 5.066667!
        Me.Line224.Width = 0!
        Me.Line224.X1 = 2.6!
        Me.Line224.X2 = 2.6!
        Me.Line224.Y1 = 5.066667!
        Me.Line224.Y2 = 5.333334!
        '
        'Line225
        '
        Me.Line225.Height = 0.2666664!
        Me.Line225.Left = 4.133333!
        Me.Line225.LineWeight = 1!
        Me.Line225.Name = "Line225"
        Me.Line225.Top = 5.066668!
        Me.Line225.Width = 0!
        Me.Line225.X1 = 4.133333!
        Me.Line225.X2 = 4.133333!
        Me.Line225.Y1 = 5.066668!
        Me.Line225.Y2 = 5.333334!
        '
        'Line226
        '
        Me.Line226.Height = 0.2666664!
        Me.Line226.Left = 5.199998!
        Me.Line226.LineWeight = 1!
        Me.Line226.Name = "Line226"
        Me.Line226.Top = 5.066668!
        Me.Line226.Width = 0!
        Me.Line226.X1 = 5.199998!
        Me.Line226.X2 = 5.199998!
        Me.Line226.Y1 = 5.066668!
        Me.Line226.Y2 = 5.333334!
        '
        'Line227
        '
        Me.Line227.Height = 0.2666674!
        Me.Line227.Left = 5.733331!
        Me.Line227.LineWeight = 1!
        Me.Line227.Name = "Line227"
        Me.Line227.Top = 5.066667!
        Me.Line227.Width = 0!
        Me.Line227.X1 = 5.733331!
        Me.Line227.X2 = 5.733331!
        Me.Line227.Y1 = 5.066667!
        Me.Line227.Y2 = 5.333334!
        '
        'Line228
        '
        Me.Line228.Height = 0.2666664!
        Me.Line228.Left = 6.266663!
        Me.Line228.LineWeight = 1!
        Me.Line228.Name = "Line228"
        Me.Line228.Top = 5.066668!
        Me.Line228.Width = 0!
        Me.Line228.X1 = 6.266663!
        Me.Line228.X2 = 6.266663!
        Me.Line228.Y1 = 5.066668!
        Me.Line228.Y2 = 5.333334!
        '
        'Line229
        '
        Me.Line229.Height = 0.2666674!
        Me.Line229.Left = 7.26666!
        Me.Line229.LineWeight = 1!
        Me.Line229.Name = "Line229"
        Me.Line229.Top = 5.066667!
        Me.Line229.Width = 0!
        Me.Line229.X1 = 7.26666!
        Me.Line229.X2 = 7.26666!
        Me.Line229.Y1 = 5.066667!
        Me.Line229.Y2 = 5.333334!
        '
        'Line230
        '
        Me.Line230.Height = 0!
        Me.Line230.Left = 0.06666667!
        Me.Line230.LineWeight = 1!
        Me.Line230.Name = "Line230"
        Me.Line230.Top = 5.333334!
        Me.Line230.Width = 7.2!
        Me.Line230.X1 = 0.06666667!
        Me.Line230.X2 = 7.266667!
        Me.Line230.Y1 = 5.333334!
        Me.Line230.Y2 = 5.333334!
        '
        'Line231
        '
        Me.Line231.Height = 0.2666669!
        Me.Line231.Left = 0.06666667!
        Me.Line231.LineWeight = 1!
        Me.Line231.Name = "Line231"
        Me.Line231.Top = 5.333334!
        Me.Line231.Width = 0!
        Me.Line231.X1 = 0.06666667!
        Me.Line231.X2 = 0.06666667!
        Me.Line231.Y1 = 5.333334!
        Me.Line231.Y2 = 5.600001!
        '
        'Line232
        '
        Me.Line232.Height = 0.2666669!
        Me.Line232.Left = 0.5333334!
        Me.Line232.LineWeight = 1!
        Me.Line232.Name = "Line232"
        Me.Line232.Top = 5.333334!
        Me.Line232.Width = 0!
        Me.Line232.X1 = 0.5333334!
        Me.Line232.X2 = 0.5333334!
        Me.Line232.Y1 = 5.333334!
        Me.Line232.Y2 = 5.600001!
        '
        'Line233
        '
        Me.Line233.Height = 0.2666669!
        Me.Line233.Left = 1.333333!
        Me.Line233.LineWeight = 1!
        Me.Line233.Name = "Line233"
        Me.Line233.Top = 5.333334!
        Me.Line233.Width = 0!
        Me.Line233.X1 = 1.333333!
        Me.Line233.X2 = 1.333333!
        Me.Line233.Y1 = 5.333334!
        Me.Line233.Y2 = 5.600001!
        '
        'Line234
        '
        Me.Line234.Height = 0.2666669!
        Me.Line234.Left = 1.995834!
        Me.Line234.LineWeight = 1!
        Me.Line234.Name = "Line234"
        Me.Line234.Top = 5.333334!
        Me.Line234.Width = 0!
        Me.Line234.X1 = 1.995834!
        Me.Line234.X2 = 1.995834!
        Me.Line234.Y1 = 5.333334!
        Me.Line234.Y2 = 5.600001!
        '
        'Line235
        '
        Me.Line235.Height = 0.2666669!
        Me.Line235.Left = 2.6!
        Me.Line235.LineWeight = 1!
        Me.Line235.Name = "Line235"
        Me.Line235.Top = 5.333334!
        Me.Line235.Width = 0!
        Me.Line235.X1 = 2.6!
        Me.Line235.X2 = 2.6!
        Me.Line235.Y1 = 5.333334!
        Me.Line235.Y2 = 5.600001!
        '
        'Line236
        '
        Me.Line236.Height = 0.2666669!
        Me.Line236.Left = 4.133333!
        Me.Line236.LineWeight = 1!
        Me.Line236.Name = "Line236"
        Me.Line236.Top = 5.333334!
        Me.Line236.Width = 0!
        Me.Line236.X1 = 4.133333!
        Me.Line236.X2 = 4.133333!
        Me.Line236.Y1 = 5.333334!
        Me.Line236.Y2 = 5.600001!
        '
        'Line237
        '
        Me.Line237.Height = 0.2666669!
        Me.Line237.Left = 5.199998!
        Me.Line237.LineWeight = 1!
        Me.Line237.Name = "Line237"
        Me.Line237.Top = 5.333334!
        Me.Line237.Width = 0!
        Me.Line237.X1 = 5.199998!
        Me.Line237.X2 = 5.199998!
        Me.Line237.Y1 = 5.333334!
        Me.Line237.Y2 = 5.600001!
        '
        'Line238
        '
        Me.Line238.Height = 0.2666669!
        Me.Line238.Left = 5.733331!
        Me.Line238.LineWeight = 1!
        Me.Line238.Name = "Line238"
        Me.Line238.Top = 5.333334!
        Me.Line238.Width = 0!
        Me.Line238.X1 = 5.733331!
        Me.Line238.X2 = 5.733331!
        Me.Line238.Y1 = 5.333334!
        Me.Line238.Y2 = 5.600001!
        '
        'Line239
        '
        Me.Line239.Height = 0.2666669!
        Me.Line239.Left = 6.266663!
        Me.Line239.LineWeight = 1!
        Me.Line239.Name = "Line239"
        Me.Line239.Top = 5.333334!
        Me.Line239.Width = 0!
        Me.Line239.X1 = 6.266663!
        Me.Line239.X2 = 6.266663!
        Me.Line239.Y1 = 5.333334!
        Me.Line239.Y2 = 5.600001!
        '
        'Line240
        '
        Me.Line240.Height = 0.2666669!
        Me.Line240.Left = 7.26666!
        Me.Line240.LineWeight = 1!
        Me.Line240.Name = "Line240"
        Me.Line240.Top = 5.333334!
        Me.Line240.Width = 0!
        Me.Line240.X1 = 7.26666!
        Me.Line240.X2 = 7.26666!
        Me.Line240.Y1 = 5.333334!
        Me.Line240.Y2 = 5.600001!
        '
        'Line241
        '
        Me.Line241.Height = 0!
        Me.Line241.Left = 0.06666667!
        Me.Line241.LineWeight = 1!
        Me.Line241.Name = "Line241"
        Me.Line241.Top = 5.600001!
        Me.Line241.Width = 7.2!
        Me.Line241.X1 = 0.06666667!
        Me.Line241.X2 = 7.266667!
        Me.Line241.Y1 = 5.600001!
        Me.Line241.Y2 = 5.600001!
        '
        'Line242
        '
        Me.Line242.Height = 0.2666674!
        Me.Line242.Left = 0.06666667!
        Me.Line242.LineWeight = 1!
        Me.Line242.Name = "Line242"
        Me.Line242.Top = 5.600001!
        Me.Line242.Width = 0!
        Me.Line242.X1 = 0.06666667!
        Me.Line242.X2 = 0.06666667!
        Me.Line242.Y1 = 5.600001!
        Me.Line242.Y2 = 5.866668!
        '
        'Line243
        '
        Me.Line243.Height = 0.2666674!
        Me.Line243.Left = 0.5333334!
        Me.Line243.LineWeight = 1!
        Me.Line243.Name = "Line243"
        Me.Line243.Top = 5.600001!
        Me.Line243.Width = 0!
        Me.Line243.X1 = 0.5333334!
        Me.Line243.X2 = 0.5333334!
        Me.Line243.Y1 = 5.600001!
        Me.Line243.Y2 = 5.866668!
        '
        'Line244
        '
        Me.Line244.Height = 0.2666674!
        Me.Line244.Left = 1.333333!
        Me.Line244.LineWeight = 1!
        Me.Line244.Name = "Line244"
        Me.Line244.Top = 5.600001!
        Me.Line244.Width = 0!
        Me.Line244.X1 = 1.333333!
        Me.Line244.X2 = 1.333333!
        Me.Line244.Y1 = 5.600001!
        Me.Line244.Y2 = 5.866668!
        '
        'Line245
        '
        Me.Line245.Height = 0.2666674!
        Me.Line245.Left = 1.995834!
        Me.Line245.LineWeight = 1!
        Me.Line245.Name = "Line245"
        Me.Line245.Top = 5.600001!
        Me.Line245.Width = 0!
        Me.Line245.X1 = 1.995834!
        Me.Line245.X2 = 1.995834!
        Me.Line245.Y1 = 5.600001!
        Me.Line245.Y2 = 5.866668!
        '
        'Line246
        '
        Me.Line246.Height = 0.2666674!
        Me.Line246.Left = 2.6!
        Me.Line246.LineWeight = 1!
        Me.Line246.Name = "Line246"
        Me.Line246.Top = 5.600001!
        Me.Line246.Width = 0!
        Me.Line246.X1 = 2.6!
        Me.Line246.X2 = 2.6!
        Me.Line246.Y1 = 5.600001!
        Me.Line246.Y2 = 5.866668!
        '
        'Line247
        '
        Me.Line247.Height = 0.2666674!
        Me.Line247.Left = 4.133333!
        Me.Line247.LineWeight = 1!
        Me.Line247.Name = "Line247"
        Me.Line247.Top = 5.600001!
        Me.Line247.Width = 0!
        Me.Line247.X1 = 4.133333!
        Me.Line247.X2 = 4.133333!
        Me.Line247.Y1 = 5.600001!
        Me.Line247.Y2 = 5.866668!
        '
        'Line248
        '
        Me.Line248.Height = 0.2666674!
        Me.Line248.Left = 5.199998!
        Me.Line248.LineWeight = 1!
        Me.Line248.Name = "Line248"
        Me.Line248.Top = 5.600001!
        Me.Line248.Width = 0!
        Me.Line248.X1 = 5.199998!
        Me.Line248.X2 = 5.199998!
        Me.Line248.Y1 = 5.600001!
        Me.Line248.Y2 = 5.866668!
        '
        'Line249
        '
        Me.Line249.Height = 0.2666674!
        Me.Line249.Left = 5.733331!
        Me.Line249.LineWeight = 1!
        Me.Line249.Name = "Line249"
        Me.Line249.Top = 5.600001!
        Me.Line249.Width = 0!
        Me.Line249.X1 = 5.733331!
        Me.Line249.X2 = 5.733331!
        Me.Line249.Y1 = 5.600001!
        Me.Line249.Y2 = 5.866668!
        '
        'Line250
        '
        Me.Line250.Height = 0.2666674!
        Me.Line250.Left = 6.266663!
        Me.Line250.LineWeight = 1!
        Me.Line250.Name = "Line250"
        Me.Line250.Top = 5.600001!
        Me.Line250.Width = 0!
        Me.Line250.X1 = 6.266663!
        Me.Line250.X2 = 6.266663!
        Me.Line250.Y1 = 5.600001!
        Me.Line250.Y2 = 5.866668!
        '
        'Line251
        '
        Me.Line251.Height = 0.2666674!
        Me.Line251.Left = 7.26666!
        Me.Line251.LineWeight = 1!
        Me.Line251.Name = "Line251"
        Me.Line251.Top = 5.600001!
        Me.Line251.Width = 0!
        Me.Line251.X1 = 7.26666!
        Me.Line251.X2 = 7.26666!
        Me.Line251.Y1 = 5.600001!
        Me.Line251.Y2 = 5.866668!
        '
        'Line252
        '
        Me.Line252.Height = 0!
        Me.Line252.Left = 0.06666667!
        Me.Line252.LineWeight = 1!
        Me.Line252.Name = "Line252"
        Me.Line252.Top = 5.866667!
        Me.Line252.Width = 7.2!
        Me.Line252.X1 = 0.06666667!
        Me.Line252.X2 = 7.266667!
        Me.Line252.Y1 = 5.866667!
        Me.Line252.Y2 = 5.866667!
        '
        'Line253
        '
        Me.Line253.Height = 0.2666669!
        Me.Line253.Left = 0.06666667!
        Me.Line253.LineWeight = 1!
        Me.Line253.Name = "Line253"
        Me.Line253.Top = 5.866667!
        Me.Line253.Width = 0!
        Me.Line253.X1 = 0.06666667!
        Me.Line253.X2 = 0.06666667!
        Me.Line253.Y1 = 5.866667!
        Me.Line253.Y2 = 6.133334!
        '
        'Line254
        '
        Me.Line254.Height = 0.2666669!
        Me.Line254.Left = 0.5333334!
        Me.Line254.LineWeight = 1!
        Me.Line254.Name = "Line254"
        Me.Line254.Top = 5.866667!
        Me.Line254.Width = 0!
        Me.Line254.X1 = 0.5333334!
        Me.Line254.X2 = 0.5333334!
        Me.Line254.Y1 = 5.866667!
        Me.Line254.Y2 = 6.133334!
        '
        'Line255
        '
        Me.Line255.Height = 0.2666669!
        Me.Line255.Left = 1.333333!
        Me.Line255.LineWeight = 1!
        Me.Line255.Name = "Line255"
        Me.Line255.Top = 5.866667!
        Me.Line255.Width = 0!
        Me.Line255.X1 = 1.333333!
        Me.Line255.X2 = 1.333333!
        Me.Line255.Y1 = 5.866667!
        Me.Line255.Y2 = 6.133334!
        '
        'Line256
        '
        Me.Line256.Height = 0.2666669!
        Me.Line256.Left = 1.995834!
        Me.Line256.LineWeight = 1!
        Me.Line256.Name = "Line256"
        Me.Line256.Top = 5.866667!
        Me.Line256.Width = 0!
        Me.Line256.X1 = 1.995834!
        Me.Line256.X2 = 1.995834!
        Me.Line256.Y1 = 5.866667!
        Me.Line256.Y2 = 6.133334!
        '
        'Line257
        '
        Me.Line257.Height = 0.2666669!
        Me.Line257.Left = 2.6!
        Me.Line257.LineWeight = 1!
        Me.Line257.Name = "Line257"
        Me.Line257.Top = 5.866667!
        Me.Line257.Width = 0!
        Me.Line257.X1 = 2.6!
        Me.Line257.X2 = 2.6!
        Me.Line257.Y1 = 5.866667!
        Me.Line257.Y2 = 6.133334!
        '
        'Line258
        '
        Me.Line258.Height = 0.2666669!
        Me.Line258.Left = 4.133333!
        Me.Line258.LineWeight = 1!
        Me.Line258.Name = "Line258"
        Me.Line258.Top = 5.866667!
        Me.Line258.Width = 0!
        Me.Line258.X1 = 4.133333!
        Me.Line258.X2 = 4.133333!
        Me.Line258.Y1 = 5.866667!
        Me.Line258.Y2 = 6.133334!
        '
        'Line259
        '
        Me.Line259.Height = 0.2666669!
        Me.Line259.Left = 5.199998!
        Me.Line259.LineWeight = 1!
        Me.Line259.Name = "Line259"
        Me.Line259.Top = 5.866667!
        Me.Line259.Width = 0!
        Me.Line259.X1 = 5.199998!
        Me.Line259.X2 = 5.199998!
        Me.Line259.Y1 = 5.866667!
        Me.Line259.Y2 = 6.133334!
        '
        'Line260
        '
        Me.Line260.Height = 0.2666669!
        Me.Line260.Left = 5.733331!
        Me.Line260.LineWeight = 1!
        Me.Line260.Name = "Line260"
        Me.Line260.Top = 5.866667!
        Me.Line260.Width = 0!
        Me.Line260.X1 = 5.733331!
        Me.Line260.X2 = 5.733331!
        Me.Line260.Y1 = 5.866667!
        Me.Line260.Y2 = 6.133334!
        '
        'Line261
        '
        Me.Line261.Height = 0.2666669!
        Me.Line261.Left = 6.266663!
        Me.Line261.LineWeight = 1!
        Me.Line261.Name = "Line261"
        Me.Line261.Top = 5.866667!
        Me.Line261.Width = 0!
        Me.Line261.X1 = 6.266663!
        Me.Line261.X2 = 6.266663!
        Me.Line261.Y1 = 5.866667!
        Me.Line261.Y2 = 6.133334!
        '
        'Line262
        '
        Me.Line262.Height = 0.2666669!
        Me.Line262.Left = 7.26666!
        Me.Line262.LineWeight = 1!
        Me.Line262.Name = "Line262"
        Me.Line262.Top = 5.866667!
        Me.Line262.Width = 0!
        Me.Line262.X1 = 7.26666!
        Me.Line262.X2 = 7.26666!
        Me.Line262.Y1 = 5.866667!
        Me.Line262.Y2 = 6.133334!
        '
        'Line263
        '
        Me.Line263.Height = 0!
        Me.Line263.Left = 0.06666667!
        Me.Line263.LineWeight = 1!
        Me.Line263.Name = "Line263"
        Me.Line263.Top = 6.133334!
        Me.Line263.Width = 7.2!
        Me.Line263.X1 = 0.06666667!
        Me.Line263.X2 = 7.266667!
        Me.Line263.Y1 = 6.133334!
        Me.Line263.Y2 = 6.133334!
        '
        'Line264
        '
        Me.Line264.Height = 0.2666674!
        Me.Line264.Left = 0.06666667!
        Me.Line264.LineWeight = 1!
        Me.Line264.Name = "Line264"
        Me.Line264.Top = 6.133334!
        Me.Line264.Width = 0!
        Me.Line264.X1 = 0.06666667!
        Me.Line264.X2 = 0.06666667!
        Me.Line264.Y1 = 6.133334!
        Me.Line264.Y2 = 6.400002!
        '
        'Line265
        '
        Me.Line265.Height = 0.2666674!
        Me.Line265.Left = 0.5333334!
        Me.Line265.LineWeight = 1!
        Me.Line265.Name = "Line265"
        Me.Line265.Top = 6.133334!
        Me.Line265.Width = 0!
        Me.Line265.X1 = 0.5333334!
        Me.Line265.X2 = 0.5333334!
        Me.Line265.Y1 = 6.133334!
        Me.Line265.Y2 = 6.400002!
        '
        'Line266
        '
        Me.Line266.Height = 0.2666674!
        Me.Line266.Left = 1.333333!
        Me.Line266.LineWeight = 1!
        Me.Line266.Name = "Line266"
        Me.Line266.Top = 6.133334!
        Me.Line266.Width = 0!
        Me.Line266.X1 = 1.333333!
        Me.Line266.X2 = 1.333333!
        Me.Line266.Y1 = 6.133334!
        Me.Line266.Y2 = 6.400002!
        '
        'Line267
        '
        Me.Line267.Height = 0.2666674!
        Me.Line267.Left = 1.995834!
        Me.Line267.LineWeight = 1!
        Me.Line267.Name = "Line267"
        Me.Line267.Top = 6.133334!
        Me.Line267.Width = 0!
        Me.Line267.X1 = 1.995834!
        Me.Line267.X2 = 1.995834!
        Me.Line267.Y1 = 6.133334!
        Me.Line267.Y2 = 6.400002!
        '
        'Line268
        '
        Me.Line268.Height = 0.2666674!
        Me.Line268.Left = 2.6!
        Me.Line268.LineWeight = 1!
        Me.Line268.Name = "Line268"
        Me.Line268.Top = 6.133334!
        Me.Line268.Width = 0!
        Me.Line268.X1 = 2.6!
        Me.Line268.X2 = 2.6!
        Me.Line268.Y1 = 6.133334!
        Me.Line268.Y2 = 6.400002!
        '
        'Line269
        '
        Me.Line269.Height = 0.2666674!
        Me.Line269.Left = 4.133333!
        Me.Line269.LineWeight = 1!
        Me.Line269.Name = "Line269"
        Me.Line269.Top = 6.133334!
        Me.Line269.Width = 0!
        Me.Line269.X1 = 4.133333!
        Me.Line269.X2 = 4.133333!
        Me.Line269.Y1 = 6.133334!
        Me.Line269.Y2 = 6.400002!
        '
        'Line270
        '
        Me.Line270.Height = 0.2666674!
        Me.Line270.Left = 5.199998!
        Me.Line270.LineWeight = 1!
        Me.Line270.Name = "Line270"
        Me.Line270.Top = 6.133334!
        Me.Line270.Width = 0!
        Me.Line270.X1 = 5.199998!
        Me.Line270.X2 = 5.199998!
        Me.Line270.Y1 = 6.133334!
        Me.Line270.Y2 = 6.400002!
        '
        'Line271
        '
        Me.Line271.Height = 0.2666674!
        Me.Line271.Left = 5.733331!
        Me.Line271.LineWeight = 1!
        Me.Line271.Name = "Line271"
        Me.Line271.Top = 6.133334!
        Me.Line271.Width = 0!
        Me.Line271.X1 = 5.733331!
        Me.Line271.X2 = 5.733331!
        Me.Line271.Y1 = 6.133334!
        Me.Line271.Y2 = 6.400002!
        '
        'Line272
        '
        Me.Line272.Height = 0.2666674!
        Me.Line272.Left = 6.266663!
        Me.Line272.LineWeight = 1!
        Me.Line272.Name = "Line272"
        Me.Line272.Top = 6.133334!
        Me.Line272.Width = 0!
        Me.Line272.X1 = 6.266663!
        Me.Line272.X2 = 6.266663!
        Me.Line272.Y1 = 6.133334!
        Me.Line272.Y2 = 6.400002!
        '
        'Line273
        '
        Me.Line273.Height = 0.2666674!
        Me.Line273.Left = 7.26666!
        Me.Line273.LineWeight = 1!
        Me.Line273.Name = "Line273"
        Me.Line273.Top = 6.133334!
        Me.Line273.Width = 0!
        Me.Line273.X1 = 7.26666!
        Me.Line273.X2 = 7.26666!
        Me.Line273.Y1 = 6.133334!
        Me.Line273.Y2 = 6.400002!
        '
        'Line274
        '
        Me.Line274.Height = 0!
        Me.Line274.Left = 0.06666667!
        Me.Line274.LineWeight = 1!
        Me.Line274.Name = "Line274"
        Me.Line274.Top = 6.400001!
        Me.Line274.Width = 7.2!
        Me.Line274.X1 = 0.06666667!
        Me.Line274.X2 = 7.266667!
        Me.Line274.Y1 = 6.400001!
        Me.Line274.Y2 = 6.400001!
        '
        'Line275
        '
        Me.Line275.Height = 0.2666659!
        Me.Line275.Left = 0.06666667!
        Me.Line275.LineWeight = 1!
        Me.Line275.Name = "Line275"
        Me.Line275.Top = 6.400001!
        Me.Line275.Width = 0!
        Me.Line275.X1 = 0.06666667!
        Me.Line275.X2 = 0.06666667!
        Me.Line275.Y1 = 6.400001!
        Me.Line275.Y2 = 6.666667!
        '
        'Line276
        '
        Me.Line276.Height = 0.2666659!
        Me.Line276.Left = 0.5333334!
        Me.Line276.LineWeight = 1!
        Me.Line276.Name = "Line276"
        Me.Line276.Top = 6.400001!
        Me.Line276.Width = 0!
        Me.Line276.X1 = 0.5333334!
        Me.Line276.X2 = 0.5333334!
        Me.Line276.Y1 = 6.400001!
        Me.Line276.Y2 = 6.666667!
        '
        'Line277
        '
        Me.Line277.Height = 0.2666674!
        Me.Line277.Left = 1.333333!
        Me.Line277.LineWeight = 1!
        Me.Line277.Name = "Line277"
        Me.Line277.Top = 6.400001!
        Me.Line277.Width = 0!
        Me.Line277.X1 = 1.333333!
        Me.Line277.X2 = 1.333333!
        Me.Line277.Y1 = 6.400001!
        Me.Line277.Y2 = 6.666668!
        '
        'Line278
        '
        Me.Line278.Height = 0.2666674!
        Me.Line278.Left = 1.995834!
        Me.Line278.LineWeight = 1!
        Me.Line278.Name = "Line278"
        Me.Line278.Top = 6.400001!
        Me.Line278.Width = 0!
        Me.Line278.X1 = 1.995834!
        Me.Line278.X2 = 1.995834!
        Me.Line278.Y1 = 6.400001!
        Me.Line278.Y2 = 6.666668!
        '
        'Line279
        '
        Me.Line279.Height = 0.2666674!
        Me.Line279.Left = 2.6!
        Me.Line279.LineWeight = 1!
        Me.Line279.Name = "Line279"
        Me.Line279.Top = 6.400001!
        Me.Line279.Width = 0!
        Me.Line279.X1 = 2.6!
        Me.Line279.X2 = 2.6!
        Me.Line279.Y1 = 6.400001!
        Me.Line279.Y2 = 6.666668!
        '
        'Line280
        '
        Me.Line280.Height = 0.2666674!
        Me.Line280.Left = 4.133333!
        Me.Line280.LineWeight = 1!
        Me.Line280.Name = "Line280"
        Me.Line280.Top = 6.400001!
        Me.Line280.Width = 0!
        Me.Line280.X1 = 4.133333!
        Me.Line280.X2 = 4.133333!
        Me.Line280.Y1 = 6.400001!
        Me.Line280.Y2 = 6.666668!
        '
        'Line281
        '
        Me.Line281.Height = 0.2666674!
        Me.Line281.Left = 5.199998!
        Me.Line281.LineWeight = 1!
        Me.Line281.Name = "Line281"
        Me.Line281.Top = 6.400001!
        Me.Line281.Width = 0!
        Me.Line281.X1 = 5.199998!
        Me.Line281.X2 = 5.199998!
        Me.Line281.Y1 = 6.400001!
        Me.Line281.Y2 = 6.666668!
        '
        'Line282
        '
        Me.Line282.Height = 0.2666674!
        Me.Line282.Left = 5.733331!
        Me.Line282.LineWeight = 1!
        Me.Line282.Name = "Line282"
        Me.Line282.Top = 6.400001!
        Me.Line282.Width = 0!
        Me.Line282.X1 = 5.733331!
        Me.Line282.X2 = 5.733331!
        Me.Line282.Y1 = 6.400001!
        Me.Line282.Y2 = 6.666668!
        '
        'Line283
        '
        Me.Line283.Height = 0.2666674!
        Me.Line283.Left = 6.266663!
        Me.Line283.LineWeight = 1!
        Me.Line283.Name = "Line283"
        Me.Line283.Top = 6.400001!
        Me.Line283.Width = 0!
        Me.Line283.X1 = 6.266663!
        Me.Line283.X2 = 6.266663!
        Me.Line283.Y1 = 6.400001!
        Me.Line283.Y2 = 6.666668!
        '
        'Line284
        '
        Me.Line284.Height = 0.2666674!
        Me.Line284.Left = 7.26666!
        Me.Line284.LineWeight = 1!
        Me.Line284.Name = "Line284"
        Me.Line284.Top = 6.400001!
        Me.Line284.Width = 0!
        Me.Line284.X1 = 7.26666!
        Me.Line284.X2 = 7.26666!
        Me.Line284.Y1 = 6.400001!
        Me.Line284.Y2 = 6.666668!
        '
        'Line285
        '
        Me.Line285.Height = 0!
        Me.Line285.Left = 0.06666667!
        Me.Line285.LineWeight = 1!
        Me.Line285.Name = "Line285"
        Me.Line285.Top = 6.666667!
        Me.Line285.Width = 7.2!
        Me.Line285.X1 = 0.06666667!
        Me.Line285.X2 = 7.266667!
        Me.Line285.Y1 = 6.666667!
        Me.Line285.Y2 = 6.666667!
        '
        'Line286
        '
        Me.Line286.Height = 0.2666674!
        Me.Line286.Left = 0.06666667!
        Me.Line286.LineWeight = 1!
        Me.Line286.Name = "Line286"
        Me.Line286.Top = 6.666667!
        Me.Line286.Width = 0!
        Me.Line286.X1 = 0.06666667!
        Me.Line286.X2 = 0.06666667!
        Me.Line286.Y1 = 6.666667!
        Me.Line286.Y2 = 6.933335!
        '
        'Line287
        '
        Me.Line287.Height = 0.2666674!
        Me.Line287.Left = 0.5333334!
        Me.Line287.LineWeight = 1!
        Me.Line287.Name = "Line287"
        Me.Line287.Top = 6.666667!
        Me.Line287.Width = 0!
        Me.Line287.X1 = 0.5333334!
        Me.Line287.X2 = 0.5333334!
        Me.Line287.Y1 = 6.666667!
        Me.Line287.Y2 = 6.933335!
        '
        'Line288
        '
        Me.Line288.Height = 0.2666674!
        Me.Line288.Left = 1.333333!
        Me.Line288.LineWeight = 1!
        Me.Line288.Name = "Line288"
        Me.Line288.Top = 6.666667!
        Me.Line288.Width = 0!
        Me.Line288.X1 = 1.333333!
        Me.Line288.X2 = 1.333333!
        Me.Line288.Y1 = 6.666667!
        Me.Line288.Y2 = 6.933335!
        '
        'Line289
        '
        Me.Line289.Height = 0.2666674!
        Me.Line289.Left = 1.995834!
        Me.Line289.LineWeight = 1!
        Me.Line289.Name = "Line289"
        Me.Line289.Top = 6.666667!
        Me.Line289.Width = 0!
        Me.Line289.X1 = 1.995834!
        Me.Line289.X2 = 1.995834!
        Me.Line289.Y1 = 6.666667!
        Me.Line289.Y2 = 6.933335!
        '
        'Line290
        '
        Me.Line290.Height = 0.2666674!
        Me.Line290.Left = 2.6!
        Me.Line290.LineWeight = 1!
        Me.Line290.Name = "Line290"
        Me.Line290.Top = 6.666667!
        Me.Line290.Width = 0!
        Me.Line290.X1 = 2.6!
        Me.Line290.X2 = 2.6!
        Me.Line290.Y1 = 6.666667!
        Me.Line290.Y2 = 6.933335!
        '
        'Line291
        '
        Me.Line291.Height = 0.2666669!
        Me.Line291.Left = 4.133333!
        Me.Line291.LineWeight = 1!
        Me.Line291.Name = "Line291"
        Me.Line291.Top = 6.666668!
        Me.Line291.Width = 0!
        Me.Line291.X1 = 4.133333!
        Me.Line291.X2 = 4.133333!
        Me.Line291.Y1 = 6.666668!
        Me.Line291.Y2 = 6.933335!
        '
        'Line292
        '
        Me.Line292.Height = 0.2666669!
        Me.Line292.Left = 5.199998!
        Me.Line292.LineWeight = 1!
        Me.Line292.Name = "Line292"
        Me.Line292.Top = 6.666668!
        Me.Line292.Width = 0!
        Me.Line292.X1 = 5.199998!
        Me.Line292.X2 = 5.199998!
        Me.Line292.Y1 = 6.666668!
        Me.Line292.Y2 = 6.933335!
        '
        'Line293
        '
        Me.Line293.Height = 0.2666674!
        Me.Line293.Left = 5.733331!
        Me.Line293.LineWeight = 1!
        Me.Line293.Name = "Line293"
        Me.Line293.Top = 6.666667!
        Me.Line293.Width = 0!
        Me.Line293.X1 = 5.733331!
        Me.Line293.X2 = 5.733331!
        Me.Line293.Y1 = 6.666667!
        Me.Line293.Y2 = 6.933335!
        '
        'Line294
        '
        Me.Line294.Height = 0.2666669!
        Me.Line294.Left = 6.266663!
        Me.Line294.LineWeight = 1!
        Me.Line294.Name = "Line294"
        Me.Line294.Top = 6.666668!
        Me.Line294.Width = 0!
        Me.Line294.X1 = 6.266663!
        Me.Line294.X2 = 6.266663!
        Me.Line294.Y1 = 6.666668!
        Me.Line294.Y2 = 6.933335!
        '
        'Line295
        '
        Me.Line295.Height = 0.2666674!
        Me.Line295.Left = 7.26666!
        Me.Line295.LineWeight = 1!
        Me.Line295.Name = "Line295"
        Me.Line295.Top = 6.666667!
        Me.Line295.Width = 0!
        Me.Line295.X1 = 7.26666!
        Me.Line295.X2 = 7.26666!
        Me.Line295.Y1 = 6.666667!
        Me.Line295.Y2 = 6.933335!
        '
        'Line296
        '
        Me.Line296.Height = 0!
        Me.Line296.Left = 0.06666667!
        Me.Line296.LineWeight = 1!
        Me.Line296.Name = "Line296"
        Me.Line296.Top = 6.933335!
        Me.Line296.Width = 7.2!
        Me.Line296.X1 = 0.06666667!
        Me.Line296.X2 = 7.266667!
        Me.Line296.Y1 = 6.933335!
        Me.Line296.Y2 = 6.933335!
        '
        'Line297
        '
        Me.Line297.Height = 0.266665!
        Me.Line297.Left = 0.06666667!
        Me.Line297.LineWeight = 1!
        Me.Line297.Name = "Line297"
        Me.Line297.Top = 6.933335!
        Me.Line297.Width = 0!
        Me.Line297.X1 = 0.06666667!
        Me.Line297.X2 = 0.06666667!
        Me.Line297.Y1 = 6.933335!
        Me.Line297.Y2 = 7.2!
        '
        'Line298
        '
        Me.Line298.Height = 0.266665!
        Me.Line298.Left = 0.5333334!
        Me.Line298.LineWeight = 1!
        Me.Line298.Name = "Line298"
        Me.Line298.Top = 6.933335!
        Me.Line298.Width = 0!
        Me.Line298.X1 = 0.5333334!
        Me.Line298.X2 = 0.5333334!
        Me.Line298.Y1 = 6.933335!
        Me.Line298.Y2 = 7.2!
        '
        'Line299
        '
        Me.Line299.Height = 0.266665!
        Me.Line299.Left = 1.333333!
        Me.Line299.LineWeight = 1!
        Me.Line299.Name = "Line299"
        Me.Line299.Top = 6.933335!
        Me.Line299.Width = 0!
        Me.Line299.X1 = 1.333333!
        Me.Line299.X2 = 1.333333!
        Me.Line299.Y1 = 6.933335!
        Me.Line299.Y2 = 7.2!
        '
        'Line300
        '
        Me.Line300.Height = 0.266665!
        Me.Line300.Left = 1.995834!
        Me.Line300.LineWeight = 1!
        Me.Line300.Name = "Line300"
        Me.Line300.Top = 6.933335!
        Me.Line300.Width = 0!
        Me.Line300.X1 = 1.995834!
        Me.Line300.X2 = 1.995834!
        Me.Line300.Y1 = 6.933335!
        Me.Line300.Y2 = 7.2!
        '
        'Line301
        '
        Me.Line301.Height = 0.266665!
        Me.Line301.Left = 2.6!
        Me.Line301.LineWeight = 1!
        Me.Line301.Name = "Line301"
        Me.Line301.Top = 6.933335!
        Me.Line301.Width = 0!
        Me.Line301.X1 = 2.6!
        Me.Line301.X2 = 2.6!
        Me.Line301.Y1 = 6.933335!
        Me.Line301.Y2 = 7.2!
        '
        'Line302
        '
        Me.Line302.Height = 0.266665!
        Me.Line302.Left = 4.133333!
        Me.Line302.LineWeight = 1!
        Me.Line302.Name = "Line302"
        Me.Line302.Top = 6.933335!
        Me.Line302.Width = 0!
        Me.Line302.X1 = 4.133333!
        Me.Line302.X2 = 4.133333!
        Me.Line302.Y1 = 6.933335!
        Me.Line302.Y2 = 7.2!
        '
        'Line303
        '
        Me.Line303.Height = 0.266665!
        Me.Line303.Left = 5.199998!
        Me.Line303.LineWeight = 1!
        Me.Line303.Name = "Line303"
        Me.Line303.Top = 6.933335!
        Me.Line303.Width = 0!
        Me.Line303.X1 = 5.199998!
        Me.Line303.X2 = 5.199998!
        Me.Line303.Y1 = 6.933335!
        Me.Line303.Y2 = 7.2!
        '
        'Line304
        '
        Me.Line304.Height = 0.266665!
        Me.Line304.Left = 5.733331!
        Me.Line304.LineWeight = 1!
        Me.Line304.Name = "Line304"
        Me.Line304.Top = 6.933335!
        Me.Line304.Width = 0!
        Me.Line304.X1 = 5.733331!
        Me.Line304.X2 = 5.733331!
        Me.Line304.Y1 = 6.933335!
        Me.Line304.Y2 = 7.2!
        '
        'Line305
        '
        Me.Line305.Height = 0.266665!
        Me.Line305.Left = 6.266663!
        Me.Line305.LineWeight = 1!
        Me.Line305.Name = "Line305"
        Me.Line305.Top = 6.933335!
        Me.Line305.Width = 0!
        Me.Line305.X1 = 6.266663!
        Me.Line305.X2 = 6.266663!
        Me.Line305.Y1 = 6.933335!
        Me.Line305.Y2 = 7.2!
        '
        'Line306
        '
        Me.Line306.Height = 0.266665!
        Me.Line306.Left = 7.26666!
        Me.Line306.LineWeight = 1!
        Me.Line306.Name = "Line306"
        Me.Line306.Top = 6.933335!
        Me.Line306.Width = 0!
        Me.Line306.X1 = 7.26666!
        Me.Line306.X2 = 7.26666!
        Me.Line306.Y1 = 6.933335!
        Me.Line306.Y2 = 7.2!
        '
        'Line307
        '
        Me.Line307.Height = 0!
        Me.Line307.Left = 0.06666667!
        Me.Line307.LineWeight = 1!
        Me.Line307.Name = "Line307"
        Me.Line307.Top = 7.2!
        Me.Line307.Width = 7.2!
        Me.Line307.X1 = 0.06666667!
        Me.Line307.X2 = 7.266667!
        Me.Line307.Y1 = 7.2!
        Me.Line307.Y2 = 7.2!
        '
        'Line308
        '
        Me.Line308.Height = 0.2666669!
        Me.Line308.Left = 0.06666667!
        Me.Line308.LineWeight = 1!
        Me.Line308.Name = "Line308"
        Me.Line308.Top = 7.2!
        Me.Line308.Width = 0!
        Me.Line308.X1 = 0.06666667!
        Me.Line308.X2 = 0.06666667!
        Me.Line308.Y1 = 7.2!
        Me.Line308.Y2 = 7.466667!
        '
        'Line309
        '
        Me.Line309.Height = 0.2666669!
        Me.Line309.Left = 0.5333334!
        Me.Line309.LineWeight = 1!
        Me.Line309.Name = "Line309"
        Me.Line309.Top = 7.2!
        Me.Line309.Width = 0!
        Me.Line309.X1 = 0.5333334!
        Me.Line309.X2 = 0.5333334!
        Me.Line309.Y1 = 7.2!
        Me.Line309.Y2 = 7.466667!
        '
        'Line310
        '
        Me.Line310.Height = 0.2666669!
        Me.Line310.Left = 1.333333!
        Me.Line310.LineWeight = 1!
        Me.Line310.Name = "Line310"
        Me.Line310.Top = 7.2!
        Me.Line310.Width = 0!
        Me.Line310.X1 = 1.333333!
        Me.Line310.X2 = 1.333333!
        Me.Line310.Y1 = 7.2!
        Me.Line310.Y2 = 7.466667!
        '
        'Line311
        '
        Me.Line311.Height = 0.2666669!
        Me.Line311.Left = 1.995834!
        Me.Line311.LineWeight = 1!
        Me.Line311.Name = "Line311"
        Me.Line311.Top = 7.2!
        Me.Line311.Width = 0!
        Me.Line311.X1 = 1.995834!
        Me.Line311.X2 = 1.995834!
        Me.Line311.Y1 = 7.2!
        Me.Line311.Y2 = 7.466667!
        '
        'Line312
        '
        Me.Line312.Height = 0.2666669!
        Me.Line312.Left = 2.6!
        Me.Line312.LineWeight = 1!
        Me.Line312.Name = "Line312"
        Me.Line312.Top = 7.2!
        Me.Line312.Width = 0!
        Me.Line312.X1 = 2.6!
        Me.Line312.X2 = 2.6!
        Me.Line312.Y1 = 7.2!
        Me.Line312.Y2 = 7.466667!
        '
        'Line313
        '
        Me.Line313.Height = 0.2666669!
        Me.Line313.Left = 4.133333!
        Me.Line313.LineWeight = 1!
        Me.Line313.Name = "Line313"
        Me.Line313.Top = 7.2!
        Me.Line313.Width = 0!
        Me.Line313.X1 = 4.133333!
        Me.Line313.X2 = 4.133333!
        Me.Line313.Y1 = 7.2!
        Me.Line313.Y2 = 7.466667!
        '
        'Line314
        '
        Me.Line314.Height = 0.2666669!
        Me.Line314.Left = 5.199998!
        Me.Line314.LineWeight = 1!
        Me.Line314.Name = "Line314"
        Me.Line314.Top = 7.2!
        Me.Line314.Width = 0!
        Me.Line314.X1 = 5.199998!
        Me.Line314.X2 = 5.199998!
        Me.Line314.Y1 = 7.2!
        Me.Line314.Y2 = 7.466667!
        '
        'Line315
        '
        Me.Line315.Height = 0.2666669!
        Me.Line315.Left = 5.733331!
        Me.Line315.LineWeight = 1!
        Me.Line315.Name = "Line315"
        Me.Line315.Top = 7.2!
        Me.Line315.Width = 0!
        Me.Line315.X1 = 5.733331!
        Me.Line315.X2 = 5.733331!
        Me.Line315.Y1 = 7.2!
        Me.Line315.Y2 = 7.466667!
        '
        'Line316
        '
        Me.Line316.Height = 0.2666669!
        Me.Line316.Left = 6.266663!
        Me.Line316.LineWeight = 1!
        Me.Line316.Name = "Line316"
        Me.Line316.Top = 7.2!
        Me.Line316.Width = 0!
        Me.Line316.X1 = 6.266663!
        Me.Line316.X2 = 6.266663!
        Me.Line316.Y1 = 7.2!
        Me.Line316.Y2 = 7.466667!
        '
        'Line317
        '
        Me.Line317.Height = 0.2666669!
        Me.Line317.Left = 7.26666!
        Me.Line317.LineWeight = 1!
        Me.Line317.Name = "Line317"
        Me.Line317.Top = 7.2!
        Me.Line317.Width = 0!
        Me.Line317.X1 = 7.26666!
        Me.Line317.X2 = 7.26666!
        Me.Line317.Y1 = 7.2!
        Me.Line317.Y2 = 7.466667!
        '
        'Line318
        '
        Me.Line318.Height = 0!
        Me.Line318.Left = 0.06666667!
        Me.Line318.LineWeight = 1!
        Me.Line318.Name = "Line318"
        Me.Line318.Top = 7.466667!
        Me.Line318.Width = 7.2!
        Me.Line318.X1 = 0.06666667!
        Me.Line318.X2 = 7.266667!
        Me.Line318.Y1 = 7.466667!
        Me.Line318.Y2 = 7.466667!
        '
        'Line319
        '
        Me.Line319.Height = 0.2666664!
        Me.Line319.Left = 0.06666667!
        Me.Line319.LineWeight = 1!
        Me.Line319.Name = "Line319"
        Me.Line319.Top = 7.466667!
        Me.Line319.Width = 0!
        Me.Line319.X1 = 0.06666667!
        Me.Line319.X2 = 0.06666667!
        Me.Line319.Y1 = 7.466667!
        Me.Line319.Y2 = 7.733333!
        '
        'Line320
        '
        Me.Line320.Height = 0.2666664!
        Me.Line320.Left = 0.5333334!
        Me.Line320.LineWeight = 1!
        Me.Line320.Name = "Line320"
        Me.Line320.Top = 7.466667!
        Me.Line320.Width = 0!
        Me.Line320.X1 = 0.5333334!
        Me.Line320.X2 = 0.5333334!
        Me.Line320.Y1 = 7.466667!
        Me.Line320.Y2 = 7.733333!
        '
        'Line321
        '
        Me.Line321.Height = 0.2666664!
        Me.Line321.Left = 1.333333!
        Me.Line321.LineWeight = 1!
        Me.Line321.Name = "Line321"
        Me.Line321.Top = 7.466667!
        Me.Line321.Width = 0!
        Me.Line321.X1 = 1.333333!
        Me.Line321.X2 = 1.333333!
        Me.Line321.Y1 = 7.466667!
        Me.Line321.Y2 = 7.733333!
        '
        'Line322
        '
        Me.Line322.Height = 0.2666664!
        Me.Line322.Left = 1.995834!
        Me.Line322.LineWeight = 1!
        Me.Line322.Name = "Line322"
        Me.Line322.Top = 7.466667!
        Me.Line322.Width = 0!
        Me.Line322.X1 = 1.995834!
        Me.Line322.X2 = 1.995834!
        Me.Line322.Y1 = 7.466667!
        Me.Line322.Y2 = 7.733333!
        '
        'Line323
        '
        Me.Line323.Height = 0.2666664!
        Me.Line323.Left = 2.6!
        Me.Line323.LineWeight = 1!
        Me.Line323.Name = "Line323"
        Me.Line323.Top = 7.466667!
        Me.Line323.Width = 0!
        Me.Line323.X1 = 2.6!
        Me.Line323.X2 = 2.6!
        Me.Line323.Y1 = 7.466667!
        Me.Line323.Y2 = 7.733333!
        '
        'Line324
        '
        Me.Line324.Height = 0.2666664!
        Me.Line324.Left = 4.133333!
        Me.Line324.LineWeight = 1!
        Me.Line324.Name = "Line324"
        Me.Line324.Top = 7.466667!
        Me.Line324.Width = 0!
        Me.Line324.X1 = 4.133333!
        Me.Line324.X2 = 4.133333!
        Me.Line324.Y1 = 7.466667!
        Me.Line324.Y2 = 7.733333!
        '
        'Line325
        '
        Me.Line325.Height = 0.2666664!
        Me.Line325.Left = 5.199998!
        Me.Line325.LineWeight = 1!
        Me.Line325.Name = "Line325"
        Me.Line325.Top = 7.466667!
        Me.Line325.Width = 0!
        Me.Line325.X1 = 5.199998!
        Me.Line325.X2 = 5.199998!
        Me.Line325.Y1 = 7.466667!
        Me.Line325.Y2 = 7.733333!
        '
        'Line326
        '
        Me.Line326.Height = 0.2666664!
        Me.Line326.Left = 5.733331!
        Me.Line326.LineWeight = 1!
        Me.Line326.Name = "Line326"
        Me.Line326.Top = 7.466667!
        Me.Line326.Width = 0!
        Me.Line326.X1 = 5.733331!
        Me.Line326.X2 = 5.733331!
        Me.Line326.Y1 = 7.466667!
        Me.Line326.Y2 = 7.733333!
        '
        'Line327
        '
        Me.Line327.Height = 0.2666664!
        Me.Line327.Left = 6.266663!
        Me.Line327.LineWeight = 1!
        Me.Line327.Name = "Line327"
        Me.Line327.Top = 7.466667!
        Me.Line327.Width = 0!
        Me.Line327.X1 = 6.266663!
        Me.Line327.X2 = 6.266663!
        Me.Line327.Y1 = 7.466667!
        Me.Line327.Y2 = 7.733333!
        '
        'Line328
        '
        Me.Line328.Height = 0.2666664!
        Me.Line328.Left = 7.26666!
        Me.Line328.LineWeight = 1!
        Me.Line328.Name = "Line328"
        Me.Line328.Top = 7.466667!
        Me.Line328.Width = 0!
        Me.Line328.X1 = 7.26666!
        Me.Line328.X2 = 7.26666!
        Me.Line328.Y1 = 7.466667!
        Me.Line328.Y2 = 7.733333!
        '
        'Line329
        '
        Me.Line329.Height = 0!
        Me.Line329.Left = 0.06666667!
        Me.Line329.LineWeight = 1!
        Me.Line329.Name = "Line329"
        Me.Line329.Top = 7.733333!
        Me.Line329.Width = 7.2!
        Me.Line329.X1 = 0.06666667!
        Me.Line329.X2 = 7.266667!
        Me.Line329.Y1 = 7.733333!
        Me.Line329.Y2 = 7.733333!
        '
        'Line330
        '
        Me.Line330.Height = 0.2666669!
        Me.Line330.Left = 0.06666667!
        Me.Line330.LineWeight = 1!
        Me.Line330.Name = "Line330"
        Me.Line330.Top = 7.733333!
        Me.Line330.Width = 0!
        Me.Line330.X1 = 0.06666667!
        Me.Line330.X2 = 0.06666667!
        Me.Line330.Y1 = 7.733333!
        Me.Line330.Y2 = 8!
        '
        'Line331
        '
        Me.Line331.Height = 0.2666669!
        Me.Line331.Left = 0.5333334!
        Me.Line331.LineWeight = 1!
        Me.Line331.Name = "Line331"
        Me.Line331.Top = 7.733333!
        Me.Line331.Width = 0!
        Me.Line331.X1 = 0.5333334!
        Me.Line331.X2 = 0.5333334!
        Me.Line331.Y1 = 7.733333!
        Me.Line331.Y2 = 8!
        '
        'Line332
        '
        Me.Line332.Height = 0.2666669!
        Me.Line332.Left = 1.333333!
        Me.Line332.LineWeight = 1!
        Me.Line332.Name = "Line332"
        Me.Line332.Top = 7.733333!
        Me.Line332.Width = 0!
        Me.Line332.X1 = 1.333333!
        Me.Line332.X2 = 1.333333!
        Me.Line332.Y1 = 7.733333!
        Me.Line332.Y2 = 8!
        '
        'Line333
        '
        Me.Line333.Height = 0.2666669!
        Me.Line333.Left = 1.995834!
        Me.Line333.LineWeight = 1!
        Me.Line333.Name = "Line333"
        Me.Line333.Top = 7.733333!
        Me.Line333.Width = 0!
        Me.Line333.X1 = 1.995834!
        Me.Line333.X2 = 1.995834!
        Me.Line333.Y1 = 7.733333!
        Me.Line333.Y2 = 8!
        '
        'Line334
        '
        Me.Line334.Height = 0.2666669!
        Me.Line334.Left = 2.6!
        Me.Line334.LineWeight = 1!
        Me.Line334.Name = "Line334"
        Me.Line334.Top = 7.733333!
        Me.Line334.Width = 0!
        Me.Line334.X1 = 2.6!
        Me.Line334.X2 = 2.6!
        Me.Line334.Y1 = 7.733333!
        Me.Line334.Y2 = 8!
        '
        'Line335
        '
        Me.Line335.Height = 0.2666669!
        Me.Line335.Left = 4.133333!
        Me.Line335.LineWeight = 1!
        Me.Line335.Name = "Line335"
        Me.Line335.Top = 7.733333!
        Me.Line335.Width = 0!
        Me.Line335.X1 = 4.133333!
        Me.Line335.X2 = 4.133333!
        Me.Line335.Y1 = 7.733333!
        Me.Line335.Y2 = 8!
        '
        'Line336
        '
        Me.Line336.Height = 0.2666669!
        Me.Line336.Left = 5.199998!
        Me.Line336.LineWeight = 1!
        Me.Line336.Name = "Line336"
        Me.Line336.Top = 7.733333!
        Me.Line336.Width = 0!
        Me.Line336.X1 = 5.199998!
        Me.Line336.X2 = 5.199998!
        Me.Line336.Y1 = 7.733333!
        Me.Line336.Y2 = 8!
        '
        'Line337
        '
        Me.Line337.Height = 0.2666669!
        Me.Line337.Left = 5.733331!
        Me.Line337.LineWeight = 1!
        Me.Line337.Name = "Line337"
        Me.Line337.Top = 7.733333!
        Me.Line337.Width = 0!
        Me.Line337.X1 = 5.733331!
        Me.Line337.X2 = 5.733331!
        Me.Line337.Y1 = 7.733333!
        Me.Line337.Y2 = 8!
        '
        'Line338
        '
        Me.Line338.Height = 0.2666669!
        Me.Line338.Left = 6.266663!
        Me.Line338.LineWeight = 1!
        Me.Line338.Name = "Line338"
        Me.Line338.Top = 7.733333!
        Me.Line338.Width = 0!
        Me.Line338.X1 = 6.266663!
        Me.Line338.X2 = 6.266663!
        Me.Line338.Y1 = 7.733333!
        Me.Line338.Y2 = 8!
        '
        'Line339
        '
        Me.Line339.Height = 0.2666669!
        Me.Line339.Left = 7.26666!
        Me.Line339.LineWeight = 1!
        Me.Line339.Name = "Line339"
        Me.Line339.Top = 7.733333!
        Me.Line339.Width = 0!
        Me.Line339.X1 = 7.26666!
        Me.Line339.X2 = 7.26666!
        Me.Line339.Y1 = 7.733333!
        Me.Line339.Y2 = 8!
        '
        'Line340
        '
        Me.Line340.Height = 0!
        Me.Line340.Left = 0.06666667!
        Me.Line340.LineWeight = 1!
        Me.Line340.Name = "Line340"
        Me.Line340.Top = 8!
        Me.Line340.Width = 7.2!
        Me.Line340.X1 = 0.06666667!
        Me.Line340.X2 = 7.266667!
        Me.Line340.Y1 = 8!
        Me.Line340.Y2 = 8!
        '
        'Line341
        '
        Me.Line341.Height = 0.2666664!
        Me.Line341.Left = 0.06666667!
        Me.Line341.LineWeight = 1!
        Me.Line341.Name = "Line341"
        Me.Line341.Top = 8!
        Me.Line341.Width = 0!
        Me.Line341.X1 = 0.06666667!
        Me.Line341.X2 = 0.06666667!
        Me.Line341.Y1 = 8!
        Me.Line341.Y2 = 8.266666!
        '
        'Line342
        '
        Me.Line342.Height = 0.2666664!
        Me.Line342.Left = 0.5333334!
        Me.Line342.LineWeight = 1!
        Me.Line342.Name = "Line342"
        Me.Line342.Top = 8!
        Me.Line342.Width = 0!
        Me.Line342.X1 = 0.5333334!
        Me.Line342.X2 = 0.5333334!
        Me.Line342.Y1 = 8!
        Me.Line342.Y2 = 8.266666!
        '
        'Line343
        '
        Me.Line343.Height = 0.2666664!
        Me.Line343.Left = 1.333333!
        Me.Line343.LineWeight = 1!
        Me.Line343.Name = "Line343"
        Me.Line343.Top = 8!
        Me.Line343.Width = 0!
        Me.Line343.X1 = 1.333333!
        Me.Line343.X2 = 1.333333!
        Me.Line343.Y1 = 8!
        Me.Line343.Y2 = 8.266666!
        '
        'Line344
        '
        Me.Line344.Height = 0.2666664!
        Me.Line344.Left = 1.995834!
        Me.Line344.LineWeight = 1!
        Me.Line344.Name = "Line344"
        Me.Line344.Top = 8!
        Me.Line344.Width = 0!
        Me.Line344.X1 = 1.995834!
        Me.Line344.X2 = 1.995834!
        Me.Line344.Y1 = 8!
        Me.Line344.Y2 = 8.266666!
        '
        'Line345
        '
        Me.Line345.Height = 0.2666664!
        Me.Line345.Left = 2.6!
        Me.Line345.LineWeight = 1!
        Me.Line345.Name = "Line345"
        Me.Line345.Top = 8!
        Me.Line345.Width = 0!
        Me.Line345.X1 = 2.6!
        Me.Line345.X2 = 2.6!
        Me.Line345.Y1 = 8!
        Me.Line345.Y2 = 8.266666!
        '
        'Line346
        '
        Me.Line346.Height = 0.2666664!
        Me.Line346.Left = 4.133333!
        Me.Line346.LineWeight = 1!
        Me.Line346.Name = "Line346"
        Me.Line346.Top = 8!
        Me.Line346.Width = 0!
        Me.Line346.X1 = 4.133333!
        Me.Line346.X2 = 4.133333!
        Me.Line346.Y1 = 8!
        Me.Line346.Y2 = 8.266666!
        '
        'Line347
        '
        Me.Line347.Height = 0.2666664!
        Me.Line347.Left = 5.199998!
        Me.Line347.LineWeight = 1!
        Me.Line347.Name = "Line347"
        Me.Line347.Top = 8!
        Me.Line347.Width = 0!
        Me.Line347.X1 = 5.199998!
        Me.Line347.X2 = 5.199998!
        Me.Line347.Y1 = 8!
        Me.Line347.Y2 = 8.266666!
        '
        'Line348
        '
        Me.Line348.Height = 0.2666664!
        Me.Line348.Left = 5.733331!
        Me.Line348.LineWeight = 1!
        Me.Line348.Name = "Line348"
        Me.Line348.Top = 8!
        Me.Line348.Width = 0!
        Me.Line348.X1 = 5.733331!
        Me.Line348.X2 = 5.733331!
        Me.Line348.Y1 = 8!
        Me.Line348.Y2 = 8.266666!
        '
        'Line349
        '
        Me.Line349.Height = 0.2666664!
        Me.Line349.Left = 6.266663!
        Me.Line349.LineWeight = 1!
        Me.Line349.Name = "Line349"
        Me.Line349.Top = 8!
        Me.Line349.Width = 0!
        Me.Line349.X1 = 6.266663!
        Me.Line349.X2 = 6.266663!
        Me.Line349.Y1 = 8!
        Me.Line349.Y2 = 8.266666!
        '
        'Line350
        '
        Me.Line350.Height = 0.2666664!
        Me.Line350.Left = 7.26666!
        Me.Line350.LineWeight = 1!
        Me.Line350.Name = "Line350"
        Me.Line350.Top = 8!
        Me.Line350.Width = 0!
        Me.Line350.X1 = 7.26666!
        Me.Line350.X2 = 7.26666!
        Me.Line350.Y1 = 8!
        Me.Line350.Y2 = 8.266666!
        '
        'Line351
        '
        Me.Line351.Height = 0!
        Me.Line351.Left = 0.06666667!
        Me.Line351.LineWeight = 1!
        Me.Line351.Name = "Line351"
        Me.Line351.Top = 8.266666!
        Me.Line351.Width = 7.2!
        Me.Line351.X1 = 0.06666667!
        Me.Line351.X2 = 7.266667!
        Me.Line351.Y1 = 8.266666!
        Me.Line351.Y2 = 8.266666!
        '
        'Line352
        '
        Me.Line352.Height = 0.2666674!
        Me.Line352.Left = 0.06666667!
        Me.Line352.LineWeight = 1!
        Me.Line352.Name = "Line352"
        Me.Line352.Top = 8.266666!
        Me.Line352.Width = 0!
        Me.Line352.X1 = 0.06666667!
        Me.Line352.X2 = 0.06666667!
        Me.Line352.Y1 = 8.266666!
        Me.Line352.Y2 = 8.533334!
        '
        'Line353
        '
        Me.Line353.Height = 0.2666674!
        Me.Line353.Left = 0.5333334!
        Me.Line353.LineWeight = 1!
        Me.Line353.Name = "Line353"
        Me.Line353.Top = 8.266666!
        Me.Line353.Width = 0!
        Me.Line353.X1 = 0.5333334!
        Me.Line353.X2 = 0.5333334!
        Me.Line353.Y1 = 8.266666!
        Me.Line353.Y2 = 8.533334!
        '
        'Line354
        '
        Me.Line354.Height = 0.2666674!
        Me.Line354.Left = 1.333333!
        Me.Line354.LineWeight = 1!
        Me.Line354.Name = "Line354"
        Me.Line354.Top = 8.266666!
        Me.Line354.Width = 0!
        Me.Line354.X1 = 1.333333!
        Me.Line354.X2 = 1.333333!
        Me.Line354.Y1 = 8.266666!
        Me.Line354.Y2 = 8.533334!
        '
        'Line355
        '
        Me.Line355.Height = 0.2666674!
        Me.Line355.Left = 1.995834!
        Me.Line355.LineWeight = 1!
        Me.Line355.Name = "Line355"
        Me.Line355.Top = 8.266666!
        Me.Line355.Width = 0!
        Me.Line355.X1 = 1.995834!
        Me.Line355.X2 = 1.995834!
        Me.Line355.Y1 = 8.266666!
        Me.Line355.Y2 = 8.533334!
        '
        'Line356
        '
        Me.Line356.Height = 0.2666674!
        Me.Line356.Left = 2.6!
        Me.Line356.LineWeight = 1!
        Me.Line356.Name = "Line356"
        Me.Line356.Top = 8.266666!
        Me.Line356.Width = 0!
        Me.Line356.X1 = 2.6!
        Me.Line356.X2 = 2.6!
        Me.Line356.Y1 = 8.266666!
        Me.Line356.Y2 = 8.533334!
        '
        'Line357
        '
        Me.Line357.Height = 0.2666674!
        Me.Line357.Left = 4.133333!
        Me.Line357.LineWeight = 1!
        Me.Line357.Name = "Line357"
        Me.Line357.Top = 8.266666!
        Me.Line357.Width = 0!
        Me.Line357.X1 = 4.133333!
        Me.Line357.X2 = 4.133333!
        Me.Line357.Y1 = 8.266666!
        Me.Line357.Y2 = 8.533334!
        '
        'Line358
        '
        Me.Line358.Height = 0.2666674!
        Me.Line358.Left = 5.199998!
        Me.Line358.LineWeight = 1!
        Me.Line358.Name = "Line358"
        Me.Line358.Top = 8.266666!
        Me.Line358.Width = 0!
        Me.Line358.X1 = 5.199998!
        Me.Line358.X2 = 5.199998!
        Me.Line358.Y1 = 8.266666!
        Me.Line358.Y2 = 8.533334!
        '
        'Line359
        '
        Me.Line359.Height = 0.2666674!
        Me.Line359.Left = 5.733331!
        Me.Line359.LineWeight = 1!
        Me.Line359.Name = "Line359"
        Me.Line359.Top = 8.266666!
        Me.Line359.Width = 0!
        Me.Line359.X1 = 5.733331!
        Me.Line359.X2 = 5.733331!
        Me.Line359.Y1 = 8.266666!
        Me.Line359.Y2 = 8.533334!
        '
        'Line360
        '
        Me.Line360.Height = 0.2666674!
        Me.Line360.Left = 6.266663!
        Me.Line360.LineWeight = 1!
        Me.Line360.Name = "Line360"
        Me.Line360.Top = 8.266666!
        Me.Line360.Width = 0!
        Me.Line360.X1 = 6.266663!
        Me.Line360.X2 = 6.266663!
        Me.Line360.Y1 = 8.266666!
        Me.Line360.Y2 = 8.533334!
        '
        'Line361
        '
        Me.Line361.Height = 0.2666674!
        Me.Line361.Left = 7.26666!
        Me.Line361.LineWeight = 1!
        Me.Line361.Name = "Line361"
        Me.Line361.Top = 8.266666!
        Me.Line361.Width = 0!
        Me.Line361.X1 = 7.26666!
        Me.Line361.X2 = 7.26666!
        Me.Line361.Y1 = 8.266666!
        Me.Line361.Y2 = 8.533334!
        '
        'Line362
        '
        Me.Line362.Height = 0!
        Me.Line362.Left = 0.06666667!
        Me.Line362.LineWeight = 1!
        Me.Line362.Name = "Line362"
        Me.Line362.Top = 8.533334!
        Me.Line362.Width = 7.2!
        Me.Line362.X1 = 0.06666667!
        Me.Line362.X2 = 7.266667!
        Me.Line362.Y1 = 8.533334!
        Me.Line362.Y2 = 8.533334!
        '
        'Line363
        '
        Me.Line363.Height = 0!
        Me.Line363.Left = 0.06666667!
        Me.Line363.LineWeight = 1!
        Me.Line363.Name = "Line363"
        Me.Line363.Top = 1.490116E-08!
        Me.Line363.Width = 7.2!
        Me.Line363.X1 = 0.06666667!
        Me.Line363.X2 = 7.266667!
        Me.Line363.Y1 = 1.490116E-08!
        Me.Line363.Y2 = 1.490116E-08!
        '
        'Label16
        '
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.1333333!
        Me.Label16.MultiLine = false
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label16.Text = "1.次ページ以降に記載がない場合に、使用して下さい。"
        Me.Label16.Top = 0.06666667!
        Me.Label16.Width = 5.933333!
        '
        'Label17
        '
        Me.Label17.Height = 0.2!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.1333333!
        Me.Label17.MultiLine = false
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label17.Text = "2.白紙でも全ページ返送願います。"
        Me.Label17.Top = 0.2666667!
        Me.Label17.Width = 5.933333!
        '
        'Label18
        '
        Me.Label18.Height = 0.2!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.1333333!
        Me.Label18.MultiLine = false
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label18.Text = "3.材料からの加工の場合、従来は『材料棚卸表』にて棚卸をしていただきましたが、"
        Me.Label18.Top = 0.4666668!
        Me.Label18.Width = 5.933333!
        '
        'Label19
        '
        Me.Label19.Height = 0.2!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.1333333!
        Me.Label19.MultiLine = false
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; text-align: left; vertical-align: botto" & _
            "m; white-space: nowrap"
        Me.Label19.Text = "  今回より他の部品と同様に『仕掛棚卸表』で仕掛品として棚卸願います。"
        Me.Label19.Top = 0.6666667!
        Me.Label19.Width = 5.933333!
        '
        'SectionReport1
        '
        Me.MasterReport = false
        OleDBDataSource1.ConnectionString = "Provider=MSDAORA.1;Password=mdctest;User ID=mdctest;Data Source=medical;Persist S" & _
            "ecurity Info=True"
        OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
        Me.DataSource = OleDBDataSource1
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.6!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.469!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                    "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                    "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTanaDate, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGaichuCode, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtGaichuName, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit

    End Sub

#End Region

    Private _nPage As Integer = 1

    Private _sTanaDate As String = "00000000"

    Public WriteOnly Property TanaDate() As String
        Set(ByVal sValue As String)
            _sTanaDate = sValue.Trim.PadLeft(8, "0")
        End Set
    End Property

    Private Sub mdtna0203_PageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageStart
        _nPage = 1
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        lblDate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd")
        lblPage.Text = _nPage.ToString("#").Trim.PadLeft(3, " ")
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        'lblTanaDate.Text = _sTanaDate.Substring(0, 4) + "年" + _sTanaDate.Substring(4, 2) + "月" + _sTanaDate.Substring(6, 2) + "日" 
        lblTanaDate.Text = _sTanaDate
    End Sub

End Class 
