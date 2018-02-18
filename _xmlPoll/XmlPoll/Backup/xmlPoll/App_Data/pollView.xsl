<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <xsl:variable name="summ" select="sum(Poll/answer)"></xsl:variable>
    <table>
      <tr>
        <td id="header" colspan="3">POLL RESULTS</td>
      </tr>
      <tr>
        <td id="head" colspan="3">
          <xsl:value-of select="Poll/@name"/>
        </td>
      </tr>
      <xsl:for-each select="Poll/answer">
        <tr>
          <td width="120">
            <xsl:value-of select="@text"/>
          </td>
          <td id="value">
            %<xsl:value-of select="format-number(. * 100 div $summ,'0')"/>
          </td>
          <td width="100">
            <xsl:variable name="innerSumm" select=". * 100 div $summ"></xsl:variable>
            <img src="images/bar.png" height="10" width="{$innerSumm}%" />
          </td>
        </tr>
      </xsl:for-each>
    </table>
  </xsl:template>
</xsl:stylesheet>

