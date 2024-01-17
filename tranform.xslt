<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<head>
				<title>Schedule Items</title>
				<style type="text/css">
					table {
					width: 100%;
					border-collapse: collapse;
					margin-top: 20px;
					}
					th, td {
					border: 1px solid #ddd;
					padding: 8px;
					text-align: left;
					}
					th {
					background-color: #f2f2f2;
					}
					h1 {
					text-align: center;
					}
				</style>
			</head>
			<body>
				<h1>Schedule Items</h1>
				<table>
					<tr>
						<th>ID</th>
						<th>ClassName</th>
						<th>WorkingSpaceCapacity</th>
						<th>User</th>
						<th>Teacher</th>
						<th>FreeAccessTime</th>
					</tr>
					<xsl:apply-templates select="ScheduleItems/ScheduleItem"/>
				</table>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="ScheduleItem">
		<tr>
			<td>
				<xsl:value-of select="Id"/>
			</td>
			<td>
				<xsl:value-of select="ClassName"/>
			</td>
			<td>
				<xsl:value-of select="WorkingSpaceCapacity"/>
			</td>
			<td>
				<xsl:value-of select="User"/>
			</td>
			<td>
				<xsl:value-of select="Teacher"/>
			</td>
			<td>
				<xsl:value-of select="FreeAccessTime"/>
			</td>
		</tr>
	</xsl:template>

</xsl:stylesheet>
