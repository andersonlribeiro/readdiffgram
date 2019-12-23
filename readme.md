What is Diffgram?

A DiffGram is an XML format that identifies current and original versions of data elements. The DataSet uses the DiffGram format to load and persist its contents, and to serialize its contents for transport across a network connection. When a DataSet is written as a DiffGram, it populates the DiffGram with all the necessary information to accurately recreate the contents, though not the schema, of the DataSet, including column values from both the Original and Current row versions, row error information, and row order.

When sending and retrieving a DataSet from an XML Web service, the DiffGram format is implicitly used.

This source code is a sample to intend demonstrate how to read a XML Dataset diffgram in .Net Core Framework.