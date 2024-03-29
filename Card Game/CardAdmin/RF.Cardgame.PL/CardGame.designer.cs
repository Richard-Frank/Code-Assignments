﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RF.Cardgame.PL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="rfrankdb")]
	public partial class CardGameDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblCard(tblCard instance);
    partial void UpdatetblCard(tblCard instance);
    partial void DeletetblCard(tblCard instance);
    partial void InserttblDeck(tblDeck instance);
    partial void UpdatetblDeck(tblDeck instance);
    partial void DeletetblDeck(tblDeck instance);
    partial void InserttblDeckCard(tblDeckCard instance);
    partial void UpdatetblDeckCard(tblDeckCard instance);
    partial void DeletetblDeckCard(tblDeckCard instance);
    partial void InserttblGame(tblGame instance);
    partial void UpdatetblGame(tblGame instance);
    partial void DeletetblGame(tblGame instance);
    partial void InserttblPlayer(tblPlayer instance);
    partial void UpdatetblPlayer(tblPlayer instance);
    partial void DeletetblPlayer(tblPlayer instance);
    partial void InserttblPlayerDeck(tblPlayerDeck instance);
    partial void UpdatetblPlayerDeck(tblPlayerDeck instance);
    partial void DeletetblPlayerDeck(tblPlayerDeck instance);
    partial void InserttblAdmin(tblAdmin instance);
    partial void UpdatetblAdmin(tblAdmin instance);
    partial void DeletetblAdmin(tblAdmin instance);
    #endregion
		
		public CardGameDataContext() : 
				base(global::RF.Cardgame.PL.Properties.Settings.Default.rfrankdbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CardGameDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CardGameDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CardGameDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CardGameDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblCard> tblCards
		{
			get
			{
				return this.GetTable<tblCard>();
			}
		}
		
		public System.Data.Linq.Table<tblDeck> tblDecks
		{
			get
			{
				return this.GetTable<tblDeck>();
			}
		}
		
		public System.Data.Linq.Table<tblDeckCard> tblDeckCards
		{
			get
			{
				return this.GetTable<tblDeckCard>();
			}
		}
		
		public System.Data.Linq.Table<tblGame> tblGames
		{
			get
			{
				return this.GetTable<tblGame>();
			}
		}
		
		public System.Data.Linq.Table<tblPlayer> tblPlayers
		{
			get
			{
				return this.GetTable<tblPlayer>();
			}
		}
		
		public System.Data.Linq.Table<tblPlayerDeck> tblPlayerDecks
		{
			get
			{
				return this.GetTable<tblPlayerDeck>();
			}
		}
		
		public System.Data.Linq.Table<tblAdmin> tblAdmins
		{
			get
			{
				return this.GetTable<tblAdmin>();
			}
		}
		
		public System.Data.Linq.Table<ErrorLog> ErrorLogs
		{
			get
			{
				return this.GetTable<ErrorLog>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spDeleteCards")]
		public int spDeleteCards([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> cardId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cardId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spDeleteDecks")]
		public int spDeleteDecks([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> deckId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), deckId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spGetDecksByPlayer")]
		public ISingleResult<spGetDecksByPlayerResult> spGetDecksByPlayer([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> playerId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), playerId);
			return ((ISingleResult<spGetDecksByPlayerResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spGetCardsByDeck")]
		public ISingleResult<spGetCardsByDeckResult> spGetCardsByDeck([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> deckId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), deckId);
			return ((ISingleResult<spGetCardsByDeckResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCard")]
	public partial class tblCard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
		private System.Nullable<int> _Attack;
		
		private System.Nullable<int> _Health;
		
		private System.Nullable<int> _Cost;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAttackChanging(System.Nullable<int> value);
    partial void OnAttackChanged();
    partial void OnHealthChanging(System.Nullable<int> value);
    partial void OnHealthChanged();
    partial void OnCostChanging(System.Nullable<int> value);
    partial void OnCostChanged();
    #endregion
		
		public tblCard()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attack", DbType="Int")]
		public System.Nullable<int> Attack
		{
			get
			{
				return this._Attack;
			}
			set
			{
				if ((this._Attack != value))
				{
					this.OnAttackChanging(value);
					this.SendPropertyChanging();
					this._Attack = value;
					this.SendPropertyChanged("Attack");
					this.OnAttackChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Health", DbType="Int")]
		public System.Nullable<int> Health
		{
			get
			{
				return this._Health;
			}
			set
			{
				if ((this._Health != value))
				{
					this.OnHealthChanging(value);
					this.SendPropertyChanging();
					this._Health = value;
					this.SendPropertyChanged("Health");
					this.OnHealthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Int")]
		public System.Nullable<int> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblDeck")]
	public partial class tblDeck : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public tblDeck()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblDeckCards")]
	public partial class tblDeckCard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _DeckId;
		
		private System.Guid _CardId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnDeckIdChanging(System.Guid value);
    partial void OnDeckIdChanged();
    partial void OnCardIdChanging(System.Guid value);
    partial void OnCardIdChanged();
    #endregion
		
		public tblDeckCard()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeckId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid DeckId
		{
			get
			{
				return this._DeckId;
			}
			set
			{
				if ((this._DeckId != value))
				{
					this.OnDeckIdChanging(value);
					this.SendPropertyChanging();
					this._DeckId = value;
					this.SendPropertyChanged("DeckId");
					this.OnDeckIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CardId
		{
			get
			{
				return this._CardId;
			}
			set
			{
				if ((this._CardId != value))
				{
					this.OnCardIdChanging(value);
					this.SendPropertyChanging();
					this._CardId = value;
					this.SendPropertyChanged("CardId");
					this.OnCardIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblGame")]
	public partial class tblGame : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _PlayerId;
		
		private System.Guid _OpponentId;
		
		private System.Nullable<System.DateTime> _MatchDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnPlayerIdChanging(System.Guid value);
    partial void OnPlayerIdChanged();
    partial void OnOpponentIdChanging(System.Guid value);
    partial void OnOpponentIdChanged();
    partial void OnMatchDateChanging(System.Nullable<System.DateTime> value);
    partial void OnMatchDateChanged();
    #endregion
		
		public tblGame()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpponentId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid OpponentId
		{
			get
			{
				return this._OpponentId;
			}
			set
			{
				if ((this._OpponentId != value))
				{
					this.OnOpponentIdChanging(value);
					this.SendPropertyChanging();
					this._OpponentId = value;
					this.SendPropertyChanged("OpponentId");
					this.OnOpponentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatchDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> MatchDate
		{
			get
			{
				return this._MatchDate;
			}
			set
			{
				if ((this._MatchDate != value))
				{
					this.OnMatchDateChanging(value);
					this.SendPropertyChanging();
					this._MatchDate = value;
					this.SendPropertyChanged("MatchDate");
					this.OnMatchDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblPlayer")]
	public partial class tblPlayer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
		private string _Password;
		
		private System.Nullable<int> _Wins;
		
		private System.Nullable<int> _Losses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnWinsChanging(System.Nullable<int> value);
    partial void OnWinsChanged();
    partial void OnLossesChanging(System.Nullable<int> value);
    partial void OnLossesChanged();
    #endregion
		
		public tblPlayer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Wins", DbType="Int")]
		public System.Nullable<int> Wins
		{
			get
			{
				return this._Wins;
			}
			set
			{
				if ((this._Wins != value))
				{
					this.OnWinsChanging(value);
					this.SendPropertyChanging();
					this._Wins = value;
					this.SendPropertyChanged("Wins");
					this.OnWinsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Losses", DbType="Int")]
		public System.Nullable<int> Losses
		{
			get
			{
				return this._Losses;
			}
			set
			{
				if ((this._Losses != value))
				{
					this.OnLossesChanging(value);
					this.SendPropertyChanging();
					this._Losses = value;
					this.SendPropertyChanged("Losses");
					this.OnLossesChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblPlayerDeck")]
	public partial class tblPlayerDeck : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private System.Guid _PlayerId;
		
		private System.Guid _DeckId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnPlayerIdChanging(System.Guid value);
    partial void OnPlayerIdChanged();
    partial void OnDeckIdChanging(System.Guid value);
    partial void OnDeckIdChanged();
    #endregion
		
		public tblPlayerDeck()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeckId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid DeckId
		{
			get
			{
				return this._DeckId;
			}
			set
			{
				if ((this._DeckId != value))
				{
					this.OnDeckIdChanging(value);
					this.SendPropertyChanging();
					this._DeckId = value;
					this.SendPropertyChanged("DeckId");
					this.OnDeckIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblAdmin")]
	public partial class tblAdmin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Name;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public tblAdmin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ErrorLog")]
	public partial class ErrorLog
	{
		
		private System.Nullable<System.DateTime> _ErrDate;
		
		private string _ErrThread;
		
		private string _ErrLevel;
		
		private string _ErrLogger;
		
		private string _ErrMessage;
		
		private string _ErrUser;
		
		public ErrorLog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ErrDate
		{
			get
			{
				return this._ErrDate;
			}
			set
			{
				if ((this._ErrDate != value))
				{
					this._ErrDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrThread", DbType="VarChar(200)")]
		public string ErrThread
		{
			get
			{
				return this._ErrThread;
			}
			set
			{
				if ((this._ErrThread != value))
				{
					this._ErrThread = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrLevel", DbType="VarChar(200)")]
		public string ErrLevel
		{
			get
			{
				return this._ErrLevel;
			}
			set
			{
				if ((this._ErrLevel != value))
				{
					this._ErrLevel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrLogger", DbType="VarChar(20)")]
		public string ErrLogger
		{
			get
			{
				return this._ErrLogger;
			}
			set
			{
				if ((this._ErrLogger != value))
				{
					this._ErrLogger = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrMessage", DbType="VarChar(2000)")]
		public string ErrMessage
		{
			get
			{
				return this._ErrMessage;
			}
			set
			{
				if ((this._ErrMessage != value))
				{
					this._ErrMessage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrUser", DbType="VarChar(50)")]
		public string ErrUser
		{
			get
			{
				return this._ErrUser;
			}
			set
			{
				if ((this._ErrUser != value))
				{
					this._ErrUser = value;
				}
			}
		}
	}
	
	public partial class spGetDecksByPlayerResult
	{
		
		private System.Guid _DeckId;
		
		private string _Name;
		
		public spGetDecksByPlayerResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeckId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid DeckId
		{
			get
			{
				return this._DeckId;
			}
			set
			{
				if ((this._DeckId != value))
				{
					this._DeckId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	public partial class spGetCardsByDeckResult
	{
		
		private System.Guid _CardId;
		
		private string _Name;
		
		private System.Nullable<int> _Attack;
		
		private System.Nullable<int> _Health;
		
		private System.Nullable<int> _Cost;
		
		public spGetCardsByDeckResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid CardId
		{
			get
			{
				return this._CardId;
			}
			set
			{
				if ((this._CardId != value))
				{
					this._CardId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attack", DbType="Int")]
		public System.Nullable<int> Attack
		{
			get
			{
				return this._Attack;
			}
			set
			{
				if ((this._Attack != value))
				{
					this._Attack = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Health", DbType="Int")]
		public System.Nullable<int> Health
		{
			get
			{
				return this._Health;
			}
			set
			{
				if ((this._Health != value))
				{
					this._Health = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Int")]
		public System.Nullable<int> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this._Cost = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
