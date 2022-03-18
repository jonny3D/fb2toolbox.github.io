﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FB2Toolbox
{
    public partial class ChangeProperties : Form
    {
        private bool init = false;

        public ChangeProperties()
        {
            InitializeComponent();
            List<GenreSubstitutionElement> genres = new List<GenreSubstitutionElement>();
            foreach(GenreSubstitutionElement el in FB2Config.Current.GenreSubstitutions)
            {
                genres.Add(el);
                genres.Sort();
            }
            foreach (GenreSubstitutionElement el in genres)
            {
                bookGenreText.Items.Add(el);
            }
            init = true;
        }
        public void LoadFileProperties(FB2File info, int filesCount)
        {
            if (info != null)
            {
                init = false;
                authorFirstNameText.Text = info.BookAuthorFirstName;
                authorMiddleNameText.Text = info.BookAuthorMiddleName;
                authorLastNameText.Text = info.BookAuthorLastName;
                bookSeriesText.Text = info.BookSequenceName;
                bookTitleText.Text = info.BookTitle;
                foreach (GenreSubstitutionElement el in bookGenreText.Items)
                {
                    if ((el.To == info.BookGenre) || (el.From == info.BookGenre))
                    {
                        bookGenreText.SelectedItem = el;
                        break;
                    }
                }
                bookNumberText.Value = info.BookSequenceNr.HasValue ? info.BookSequenceNr.Value : 0;
                init = true;
            }
            bookTitleCheck.Enabled = filesCount <= 1;
            Text = "Изменить метаданные " + (filesCount > 1 ? string.Format("({0} файлов)", filesCount, System.Globalization.CultureInfo.CurrentCulture) : "(один файл)");
        }
        public FileProperties GetFileProperties()
        {
            FileProperties fp = new FileProperties();
            fp.AuthorFirstNameChange = authorFirstNameCheck.Checked;
            if (fp.AuthorFirstNameChange)
                fp.AuthorFirstName = authorFirstNameText.Text.Trim();
            fp.AuthorMiddleNameChange = authorMiddleNameCheck.Checked;
            if (fp.AuthorMiddleNameChange)
                fp.AuthorMiddleName = authorMiddleNameText.Text.Trim();
            fp.AuthorLastNameChange = authorLastNameCheck.Checked;
            if (fp.AuthorLastNameChange)
                fp.AuthorLastName = authorLastNameText.Text.Trim();
            fp.SeriesChange = bookSeriesCheck.Checked;
            if (fp.SeriesChange)
                fp.Series = bookSeriesText.Text.Trim();
            fp.NumberChange = bookNumberCheck.Checked;
            if (fp.NumberChange)
                fp.Number = bookNumberText.Value.ToString();
            fp.TitleChange = bookTitleCheck.Checked;
            if (fp.TitleChange)
                fp.Title = bookTitleText.Text.Trim();
            if (bookGenreText.SelectedItem != null)
            {
                fp.GengeChange = bookGenreCheck.Checked;
                if (fp.GengeChange)
                    fp.Genre = (bookGenreText.SelectedItem as GenreSubstitutionElement).From;
            }
            return fp;
        }

        private void authorFirstNameCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!init) return;
            authorFirstNameText.BackColor = authorFirstNameCheck.Checked ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.ControlLight;
        }

        private void authorMiddleNameCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!init) return;
            authorMiddleNameText.BackColor = authorMiddleNameCheck.Checked ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.ControlLight;
        }

        private void authorLastNameCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!init) return;
            authorLastNameText.BackColor = authorLastNameCheck.Checked ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.ControlLight;
        }

        private void bookSeriesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookSeriesText.BackColor = bookSeriesCheck.Checked ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.ControlLight;
        }

        private void bookNumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookNumberText.BackColor = bookNumberCheck.Checked ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.ControlLight;
        }

        private void bookGenreCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookGenreText.BackColor = bookGenreCheck.Checked ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.ControlLight;
        }

        private void bookTitleCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookTitleText.BackColor = bookTitleCheck.Checked ? System.Drawing.SystemColors.Window : System.Drawing.SystemColors.ControlLight;
        }

        private void authorFirstNameText_TextChanged(object sender, EventArgs e)
        {
            if (!init) return;
            authorFirstNameCheck.Checked = true;
        }

        private void authorMiddleNameText_TextChanged(object sender, EventArgs e)
        {
            if (!init) return;
            authorMiddleNameCheck.Checked = true;
        }

        private void authorLastNameText_TextChanged(object sender, EventArgs e)
        {
            if (!init) return;
            authorLastNameCheck.Checked = true;
        }

        private void bookGenreText_TextChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookGenreCheck.Checked = true;
        }

        private void bookSeriesText_TextChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookSeriesCheck.Checked = true;
        }

        private void bookNumberText_ValueChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookNumberCheck.Checked = true;
        }

        private void bookTitleText_TextChanged(object sender, EventArgs e)
        {
            if (!init) return;
            bookTitleCheck.Checked = true;
        }
    }
}
